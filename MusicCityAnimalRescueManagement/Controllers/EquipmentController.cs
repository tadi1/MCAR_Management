using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.Equipment;

namespace MusicCityAnimalRescueManagement.Controllers
{
    public class EquipmentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Equipment
        public ActionResult Index()
        {
            return View(db.EquipmentItems.ToList());
        }

        // GET: Equipment/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentItem equipmentItem = db.EquipmentItems.Find(id);
            if (equipmentItem == null)
            {
                return HttpNotFound();
            }
            return View(equipmentItem);
        }

        // GET: Equipment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,description,LocationId,ItemNumber")] EquipmentItem equipmentItem)
        {
            if (ModelState.IsValid)
            {
                db.EquipmentItems.Add(equipmentItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipmentItem);
        }

        // GET: Equipment/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentItem equipmentItem = db.EquipmentItems.Find(id);
            if (equipmentItem == null)
            {
                return HttpNotFound();
            }
            return View(equipmentItem);
        }

        // POST: Equipment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,description,LocationId,ItemNumber")] EquipmentItem equipmentItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipmentItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipmentItem);
        }

        // GET: Equipment/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentItem equipmentItem = db.EquipmentItems.Find(id);
            if (equipmentItem == null)
            {
                return HttpNotFound();
            }
            return View(equipmentItem);
        }

        // POST: Equipment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            EquipmentItem equipmentItem = db.EquipmentItems.Find(id);
            db.EquipmentItems.Remove(equipmentItem);
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
