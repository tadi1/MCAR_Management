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
    public class VettingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Vettings
        public ActionResult Index()
        {
            return View(db.DogVettings.ToList());
        }

        // GET: Vettings/Details/5
        public ActionResult Details(short? id)
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

        // GET: Vettings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vettings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,AnimalsID,Sterilized,SterilizationDate,Rabies,RabiesDate,DA2PPR1,DA2PPR1Date,DA2PPR2,DA2PPR2Date,DA2PPR3,DA2PPR3Date,HeartwormTested,HeartwormDate,DewormerDate")] DogVetting dogVetting)
        {
            if (ModelState.IsValid)
            {
                db.DogVettings.Add(dogVetting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dogVetting);
        }

        // GET: Vettings/Edit/5
        public ActionResult Edit(short? id)
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

        // POST: Vettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,AnimalsID,Sterilized,SterilizationDate,Rabies,RabiesDate,DA2PPR1,DA2PPR1Date,DA2PPR2,DA2PPR2Date,DA2PPR3,DA2PPR3Date,HeartwormTested,HeartwormDate,DewormerDate")] DogVetting dogVetting)
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
