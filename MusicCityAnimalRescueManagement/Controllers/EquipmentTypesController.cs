﻿using System;
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
    public class EquipmentTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EquipmentTypes
        public ActionResult Index()
        {
            return View(db.EquipmentTypes.ToList());
        }

        // GET: EquipmentTypes/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentTypes equipmentTypes = db.EquipmentTypes.Find(id);
            if (equipmentTypes == null)
            {
                return HttpNotFound();
            }
            return View(equipmentTypes);
        }

        // GET: EquipmentTypes/Intake
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipmentTypes/Intake
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,type")] EquipmentTypes equipmentTypes)
        {
            if (ModelState.IsValid)
            {
                db.EquipmentTypes.Add(equipmentTypes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipmentTypes);
        }

        // GET: EquipmentTypes/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentTypes equipmentTypes = db.EquipmentTypes.Find(id);
            if (equipmentTypes == null)
            {
                return HttpNotFound();
            }
            return View(equipmentTypes);
        }

        // POST: EquipmentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,type")] EquipmentTypes equipmentTypes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipmentTypes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipmentTypes);
        }

        // GET: EquipmentTypes/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentTypes equipmentTypes = db.EquipmentTypes.Find(id);
            if (equipmentTypes == null)
            {
                return HttpNotFound();
            }
            return View(equipmentTypes);
        }

        // POST: EquipmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            EquipmentTypes equipmentTypes = db.EquipmentTypes.Find(id);
            db.EquipmentTypes.Remove(equipmentTypes);
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
