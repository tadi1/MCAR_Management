using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.Animals;
using MusicCityAnimalRescueManagement.ViewModels;

namespace MusicCityAnimalRescueManagement.Controllers
{
    public class VettingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        List<Animal> dogs;
        List<Animal> cats;
        List<Location> locations;
        List<Location> rabiesLocations;
        List<Medication> microchipManufactures;


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
            var viewModel = new NewDogVettingViewModel
            {
                Meds = db.Medications.Where(e => e.isForDogs).ToList(),
                RabiesLocations = rabiesLocations,
                BasicVaxLocations = locations,
                Animals = dogs,
                MicrochipManufactures = microchipManufactures
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
                db.DogVettings.Add(dogVetting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //return View(dogVetting);
            return RedirectToAction("DogIndex", "Vettings");
        }

        public ActionResult CreateCat()
        {
            var viewModel = new NewCatVettingViewModel
            {
                Meds = db.Medications.Where(e => e.isForCats).ToList(),
                RabiesLocations = rabiesLocations,
                BasicVaxLocations = locations,
                Animals = cats,
                MicrochipManufactures = microchipManufactures
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCat(CatVetting catVetting)
        {
            if (ModelState.IsValid)
            {
                db.CatVettings.Add(catVetting);
                db.SaveChanges();
                return RedirectToAction("Index");
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
            var viewModel = new NewDogVettingViewModel
            {
                DogVetting = dogVetting
            };

            if (dogVetting == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        // POST: Vettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DogEdit([Bind] DogVetting dogVetting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dogVetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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
    }
}
