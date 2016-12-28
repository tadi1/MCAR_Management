using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.AccountEntries;
using MusicCityAnimalRescueManagement.Models.Animals;
using MusicCityAnimalRescueManagement.ViewModels;

namespace MusicCityAnimalRescueManagement.Controllers
{
    public class VettingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        readonly List<Animal> dogs;
        readonly List<Animal> cats;
        readonly List<Location> locations;
        readonly List<Location> rabiesLocations;
        readonly List<Medication> microchipManufactures;


        public VettingsController()
        {
            rabiesLocations = db.Locations
                .Where(e => e.isRabiesVaxLocation)
                .OrderBy(e => e.name)
                .ThenBy(e => e.isShowLast)
                .ToList();

            dogs = db.Animals
                .Where(e => e.AnimalTypeID == 1)
                .Where(e => e.Adopted == false)
                .OrderBy(e => e.name)
                .ToList();

            cats = db.Animals
                .Where(e => e.AnimalTypeID == 0)
                .Where(e => e.Adopted == false)
                .OrderBy(e => e.name)
                .ToList();

            locations = db.Locations
                .Where(e => e.isActive)
                .Where(e => e.isBasicVaxLocation)
                .OrderBy(e => e.isShowLast)
                .ToList();

            microchipManufactures = db.Medications
                .Where(e => e.isMicrochipManufacturer)
                .ToList();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Vettings
        public ActionResult DogIndex()
        {
            return View(db.DogVettings
                .Include(e => e.Animal)
                .ToList());
        }
        public ActionResult CatIndex()
        {
            return View(db.CatVettings
                .Include(e => e.Animal)
                .ToList());
        }

        // GET: Vettings/Details/5
        public ActionResult DogDetails(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DogVetting dogVetting = db.DogVettings.Find(id);
            if (dogVetting == null)
            {
                return HttpNotFound();
            }
            return View(dogVetting);
        }

        public ActionResult CatDetails(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatVetting catVetting = db.CatVettings.Find(id);
            if (catVetting == null)
            {
                return HttpNotFound();
            }
            return View(catVetting);
        }

        // GET: Vettings/Create
        public ActionResult CreateDog()
        {
            var dogVetting = new DogVetting()
            {
                TempVettingDecimal = 0
            };

            var viewModel = new NewDogVettingViewModel
            {
                Meds = db.Medications.Where(e => e.isForDogs).ToList(),
                RabiesLocations = rabiesLocations,
                BasicVaxLocations = locations,
                Animals = dogs,
                MicrochipManufactures = microchipManufactures,
                DogVetting = dogVetting
            };
            return View(viewModel);
        }

        // POST: Vettings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDog(DogVetting dogVetting)
        {
            if (ModelState.IsValid)
            {
                if (dogVetting.TempVettingDecimal != 0)
                {
                    var eE = new ExpenseEntry();
                    dogVetting.Animal = db.Animals.Find(dogVetting.AnimalId);
                    eE.VetBillsDecimal = dogVetting.TempVettingDecimal;
                    eE.VetBillsComment = dogVetting.Animal.name + " - " + dogVetting.ReasonForVisit;
                    eE.AccountTypeID = 0;
                    eE.EffectiveDate = (dogVetting.VetDiagnosisDate == null)
                        ? DateTime.Today
                        : dogVetting.VetDiagnosisDate;


                    db.ExpenseEntries.Add(eE);
                    db.SaveChanges();
                }

                db.DogVettings.Add(dogVetting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //return View(dogVetting);
            return RedirectToAction("DogIndex", "Vettings");
        }

        public ActionResult CreateCat()
        {
            var catVetting = new CatVetting
            {
                TempVettingDecimal = 0
            };

            var viewModel = new NewCatVettingViewModel
            {
                Meds = db.Medications.Where(e => e.isForCats).ToList(),
                RabiesLocations = rabiesLocations,
                BasicVaxLocations = locations,
                Animals = cats,
                MicrochipManufactures = microchipManufactures,
                CatVetting = catVetting
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCat(CatVetting catVetting)
        {
            if (ModelState.IsValid)
            {
                if (catVetting.TempVettingDecimal != 0)
                {
                    var eE = new ExpenseEntry();
                    catVetting.Animal = db.Animals.Find(catVetting.AnimalId);
                    eE.VetBillsDecimal = catVetting.TempVettingDecimal;
                    eE.VetBillsComment = catVetting.Animal.name + " - " + catVetting.ReasonForVisit;
                    eE.AccountTypeID = 0;
                    eE.EffectiveDate = (catVetting.VetDiagnosisDate == null)
                        ? DateTime.Today
                        : catVetting.VetDiagnosisDate;
             

                    db.ExpenseEntries.Add(eE);
                    db.SaveChanges();
                }

                catVetting.VettingTotalDecimal += catVetting.TempVettingDecimal;
                db.CatVettings.Add(catVetting);
                db.SaveChanges();
                
                return RedirectToAction("CatIndex");
            }

            //return View(dogVetting);
            return RedirectToAction("CatIndex", "Vettings");
        }

        // GET: Vettings/Edit/5
        public ActionResult DogEdit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DogVetting dogVetting = db.DogVettings.Find(id);
            dogVetting.TempVettingDecimal = 0;
            if (dogVetting == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnimalId = new SelectList(db.Animals.Where(e => e.AnimalTypeID == 0).Where(e => e.Adopted == false), "id", "Name", dogVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.FleaTickLocationId);
            ViewBag.HeartwormLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.HeartwormLocationId);
            ViewBag.DA2PPR1LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DA2PPR1LocationId);
            ViewBag.DA2PPR2LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DA2PPR2LocationId);
            ViewBag.DA2PPR3LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DA2PPR3LocationId);
            ViewBag.BordetellaLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.BordetellaLocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations.Where(e => e.isRabiesVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations.Where(e => e.isRabiesVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.SterilizationLocationId);
            ViewBag.MicrochipManufacturerId = new SelectList(db.Medications.Where(e => e.isMicrochipManufacturer).OrderBy(e => e.Name), "id", "name", dogVetting.MicrochipManufacturerId);

            return View(dogVetting);
        }

        // POST: Vettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DogEdit(DogVetting dogVetting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dogVetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DogIndex");
            }
            ViewBag.AnimalId = new SelectList(db.Animals.Where(e => e.AnimalTypeID == 0).Where(e => e.Adopted == false), "id", "Name", dogVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.FleaTickLocationId);
            ViewBag.HeartwormLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.HeartwormLocationId);
            ViewBag.DA2PPR1LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DA2PPR1LocationId);
            ViewBag.DA2PPR2LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DA2PPR2LocationId);
            ViewBag.DA2PPR3LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.DA2PPR3LocationId);
            ViewBag.BordetellaLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.BordetellaLocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations.Where(e => e.isRabiesVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations.Where(e => e.isRabiesVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", dogVetting.SterilizationLocationId);
            ViewBag.MicrochipManufacturerId = new SelectList(db.Medications.Where(e => e.isMicrochipManufacturer).OrderBy(e => e.Name), "id", "name", dogVetting.MicrochipManufacturerId);


            return View(dogVetting);
        }

        // GET: Vettings/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DogVetting dogVetting = db.DogVettings.Find(id);
            if (dogVetting == null)
            {
                return HttpNotFound();
            }
            return View(dogVetting);
        }

        // POST: Vettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            DogVetting dogVetting = db.DogVettings.Find(id);
            db.DogVettings.Remove(dogVetting);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult CatEdit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatVetting catVetting = db.CatVettings.Find(id);
            catVetting.TempVettingDecimal = 0;
            if (catVetting == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnimalId = new SelectList(db.Animals.Where(e => e.AnimalTypeID == 0).Where(e => e.Adopted == false), "id", "Name", catVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.FleaTickLocationId);
            ViewBag.FVRCP1LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.FVRCP1LocationId);
            ViewBag.FVRCP2LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.FVRCP2LocationId);
            ViewBag.FVRCP3LocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.FVRCP3LocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations.Where(e => e.isBasicVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations.Where(e => e.isRabiesVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations.Where(e => e.isRabiesVaxLocation).OrderBy(e => e.isShowLast).ThenBy(e => e.name), "id", "name", catVetting.SterilizationLocationId);
            ViewBag.MicrochipManufacturerId = new SelectList(db.Medications.Where(e => e.isMicrochipManufacturer).OrderBy(e => e.Name), "id", "name", catVetting.MicrochipManufacturerId);

            return View(catVetting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CatEdit(CatVetting catVetting)
        {
            if (ModelState.IsValid)
            {
                if (catVetting.TempVettingDecimal != 0)
                {
                    var eE = new ExpenseEntry();
                    catVetting.Animal = db.Animals.Find(catVetting.AnimalId);
                    eE.VetBillsDecimal = catVetting.TempVettingDecimal;
                    eE.VetBillsComment = catVetting.Animal.name + " - " + catVetting.ReasonForVisit;
                    eE.AccountTypeID = 0;
                    eE.EffectiveDate = (catVetting.VetDiagnosisDate == null)
                        ? DateTime.Today
                        : catVetting.VetDiagnosisDate;


                    db.ExpenseEntries.Add(eE);
                    db.SaveChanges();
                }

                catVetting.VettingTotalDecimal += catVetting.TempVettingDecimal;

                db.Entry(catVetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CatIndex");
            }
            ViewBag.AnimalId = new SelectList(db.Animals.Where(e => e.AnimalTypeID == 0).Where(e => e.Adopted == false), "id", "Name", catVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations, "id", "name", catVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations, "id", "name", catVetting.FleaTickLocationId);
            ViewBag.FVRCP1LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP1LocationId);
            ViewBag.FVRCP2LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP2LocationId);
            ViewBag.FVRCP3LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP3LocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations, "id", "name", catVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations, "id", "name", catVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations, "id", "name", catVetting.SterilizationLocationId);
            ViewBag.MicrochipManufacturerId = new SelectList(db.Medications.Where(e => e.isMicrochipManufacturer).OrderBy(e => e.Name), "id", "name", catVetting.MicrochipManufacturerId);

            return View(catVetting);
        }
    }
}
