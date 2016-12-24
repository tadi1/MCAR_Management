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

namespace MusicCityAnimalRescueManagement.Controllers
{
    public class CatVettingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CatVettingsControllerTEMP
        public ActionResult Index()
        {
            var catVettings = db.CatVettings.Include(c => c.Animal).Include(c => c.DewormerLocation).Include(c => c.FleaTickLocation).Include(c => c.FVRCP1Location).Include(c => c.FVRCP2Location).Include(c => c.FVRCP3Location).Include(c => c.MicrochipLocation).Include(c => c.RabiesLocation).Include(c => c.SterilizationLocation);
            return View(catVettings.ToList());
        }

        // GET: CatVettingsControllerTEMP/Details/5
        public ActionResult Details(short? id)
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

        // GET: CatVettingsControllerTEMP/Create
        public ActionResult Create()
        {
            ViewBag.AnimalId = new SelectList(db.Animals, "id", "MCARId");
            ViewBag.DewormerLocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.FleaTickLocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.FVRCP1LocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.FVRCP2LocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.FVRCP3LocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.MicrochipLocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.RabiesLocationId = new SelectList(db.Locations, "id", "name");
            ViewBag.SterilizationLocationId = new SelectList(db.Locations, "id", "name");
            return View();
        }

        // POST: CatVettingsControllerTEMP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,AnimalId,MicrochipNumber,MicrochipLocationId,MicrochipManufacturerId,Sterilized,SterilizationDate,SterilizationLocationId,Rabies,RabiesDate,RabiesLocationId,FVRCP1,FVRCP1Date,FVRCP1LocationId,FVRCP2,FVRCP2Date,FVRCP2LocationId,FVRCP3,FVRCP3Date,FVRCP3LocationId,FVRCP3Due,DewormerDate,DewormerLocationId,FleaTickDate,FleaTickLocationId,FEVLeukTested,FEVLeukDate,FEVLeukId,FEVLeukResult,AddtlVetting,VetDiagnosis,VetDiagnosisDate,MedicationsGiven,NextVet,VettingCompleted,AdtlComments")] CatVetting catVetting)
        {
            if (ModelState.IsValid)
            {
                db.CatVettings.Add(catVetting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AnimalId = new SelectList(db.Animals, "id", "MCARId", catVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations, "id", "name", catVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations, "id", "name", catVetting.FleaTickLocationId);
            ViewBag.FVRCP1LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP1LocationId);
            ViewBag.FVRCP2LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP2LocationId);
            ViewBag.FVRCP3LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP3LocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations, "id", "name", catVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations, "id", "name", catVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations, "id", "name", catVetting.SterilizationLocationId);
            return View(catVetting);
        }

        // GET: CatVettingsControllerTEMP/Edit/5
        public ActionResult Edit(short? id)
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
            ViewBag.AnimalId = new SelectList(db.Animals, "id", "MCARId", catVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations, "id", "name", catVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations, "id", "name", catVetting.FleaTickLocationId);
            ViewBag.FVRCP1LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP1LocationId);
            ViewBag.FVRCP2LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP2LocationId);
            ViewBag.FVRCP3LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP3LocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations, "id", "name", catVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations, "id", "name", catVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations, "id", "name", catVetting.SterilizationLocationId);
            return View(catVetting);
        }

        // POST: CatVettingsControllerTEMP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,AnimalId,MicrochipNumber,MicrochipLocationId,MicrochipManufacturerId,Sterilized,SterilizationDate,SterilizationLocationId,Rabies,RabiesDate,RabiesLocationId,FVRCP1,FVRCP1Date,FVRCP1LocationId,FVRCP2,FVRCP2Date,FVRCP2LocationId,FVRCP3,FVRCP3Date,FVRCP3LocationId,FVRCP3Due,DewormerDate,DewormerLocationId,FleaTickDate,FleaTickLocationId,FEVLeukTested,FEVLeukDate,FEVLeukId,FEVLeukResult,AddtlVetting,VetDiagnosis,VetDiagnosisDate,MedicationsGiven,NextVet,VettingCompleted,AdtlComments")] CatVetting catVetting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catVetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AnimalId = new SelectList(db.Animals, "id", "MCARId", catVetting.AnimalId);
            ViewBag.DewormerLocationId = new SelectList(db.Locations, "id", "name", catVetting.DewormerLocationId);
            ViewBag.FleaTickLocationId = new SelectList(db.Locations, "id", "name", catVetting.FleaTickLocationId);
            ViewBag.FVRCP1LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP1LocationId);
            ViewBag.FVRCP2LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP2LocationId);
            ViewBag.FVRCP3LocationId = new SelectList(db.Locations, "id", "name", catVetting.FVRCP3LocationId);
            ViewBag.MicrochipLocationId = new SelectList(db.Locations, "id", "name", catVetting.MicrochipLocationId);
            ViewBag.RabiesLocationId = new SelectList(db.Locations, "id", "name", catVetting.RabiesLocationId);
            ViewBag.SterilizationLocationId = new SelectList(db.Locations, "id", "name", catVetting.SterilizationLocationId);
            return View(catVetting);
        }

        // GET: CatVettingsControllerTEMP/Delete/5
        public ActionResult Delete(short? id)
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

        // POST: CatVettingsControllerTEMP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            CatVetting catVetting = db.CatVettings.Find(id);
            db.CatVettings.Remove(catVetting);
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
