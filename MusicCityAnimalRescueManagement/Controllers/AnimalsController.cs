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
//using Rotativa;

namespace MusicCityAnimalRescueManagement.Controllers
{
    public class AnimalsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        List<Animal> animals;

        public AnimalsController()
        {
            animals = db.Animals.ToList();
        }

        // GET: Animals
        public ActionResult Index()
        {
            var animals =
                db.Animals.Include(e => e.AnimalType)
                    .Include(e => e.CurrentFoster)
                    .Include(e => e.PullLocation);
                    //.Include(e => e.Sex);
            return View(animals.ToList());
        }

        // GET: Animals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

        // GET: Animals/Create
        public ActionResult Create()
        {
            //ViewBag.AnimalTypeID = new SelectList(db.AnimalTypes, "id", "AnimalTypeName");
            //ViewBag.FosterID = new SelectList(db.Locations.Where(o => o.isFoster == true && o.isActive == true).OrderBy(o => o.name), "id", "name");

            var animalTypes = db.AnimalTypes.ToList();
            var fosterLocations = db.Locations.ToList().Where(o => o.isFoster == true && o.isActive == true).OrderBy(o => o.name);
            var pullLocations = db.Locations.ToList().Where(o => o.isPullLocation == true);
            var sexes = db.Sexes.ToList();
            //SelectList FosterIDs = new SelectList();
            //FosterIDs.
            var viewModel = new NewAnimalViewModel
            {
                AnimalTypes = animalTypes,
                FosterLocations = fosterLocations,
                PullLocations = pullLocations,
                Sexes = sexes

            };

            return View(viewModel);
        }

        
        //public ActionResult Intake()
        //{
        //    //ViewBag.AnimalTypeID = new SelectList(db.AnimalTypes, "id", "AnimalTypeName");
        //    //ViewBag.FosterID = new SelectList(db.Locations.Where(o => o.isFoster == true && o.isActive == true).OrderBy(o => o.name), "id", "name");

        //    var animalTypes = db.AnimalTypes.ToList();
        //    var fosterLocations = db.Locations.ToList().Where(o => o.isFoster == true && o.isActive == true).OrderBy(o => o.name);
        //    var pullLocations = db.Locations.ToList().Where(o => o.isPullLocation == true && o.isActive == true).OrderBy(o => o.name);
        //    var sexes = db.Sexes.ToList();
        //    //SelectList FosterIDs = new SelectList();
        //    //FosterIDs.
        //    var viewModel = new NewAnimalViewModel
        //    {
        //        AnimalTypes = animalTypes,
        //        FosterLocations = fosterLocations,
        //        PullLocations = pullLocations,
        //        Sexes = sexes

        //    };

        //    return View(viewModel);
        //}

        // POST: Animals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Animal animal)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Animals.Add(animal);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //string smcarid = DateTime.Today.Year.ToString() + 
            //animal.SimpleMCARId = 
            animal.MCARId = AssignMCARId(animal.AnimalTypeID);

            db.Animals.Add(animal);
            db.SaveChanges();
            return RedirectToAction("Index", "Animals");
            //return View(animal);
        }

        // GET: Animals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

        // POST: Animals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Animal animal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animal);
        }

        // GET: Animals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

        // POST: Animals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Animal animal = db.Animals.Find(id);
            db.Animals.Remove(animal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ContractPDF()
        {
            return View(animals);
        }

        public ActionResult Print()
        {
            //return new ActionAsPdf("Index", animals);
            return null;
        }

        public ActionResult AnimalReport()
        {
            return View(animals);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private string AssignMCARId(int AnimalTypeID)
        {
            int maxID = -1;

            //Cat
            if(AnimalTypeID == 0)
            {
                try
                {
                    maxID = int.Parse(db.Animals.Where(e => e.MCARId.Contains("-C")).Where(e => e.MCARId.Substring(e.MCARId.Length - 6, 4) == DateTime.Today.Year.ToString()).Select(e => e.MCARId.Substring(0, e.MCARId.Length - 6)).OrderByDescending(e => e).First());
                    return (maxID + 1).ToString() + DateTime.Today.Year.ToString() + "-C";
                }
                catch(InvalidOperationException)
                {
                    //This is the first animal of the year for this category
                    //1CCYY-C
                    return "1" + DateTime.Today.Year.ToString() + "-C";
                }

            }
            //Dog
            else if (AnimalTypeID == 1)
            { 
                try
                {
                    maxID = int.Parse(db.Animals.Where(e => e.MCARId.Contains("-D")).Where(e => e.MCARId.Substring(e.MCARId.Length - 6, 4) == DateTime.Today.Year.ToString()).Select(e => e.MCARId.Substring(0, e.MCARId.Length - 6)).OrderByDescending(e => e).First());
                    return (maxID + 1).ToString() + DateTime.Today.Year.ToString() + "-D";

                }
                catch (InvalidOperationException)
                {
                    //This is the first animal of the year for this category
                    //1CCYY-D
                    return "1" + DateTime.Today.Year.ToString() + "-D";
                }
            }
            else
            {
                throw new HttpException();
            }         
        }
    }
}
