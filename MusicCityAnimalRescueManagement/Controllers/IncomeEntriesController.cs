using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.AccountEntries;

namespace MusicCityAnimalRescueManagement.Controllers
{
    public class IncomeEntriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IncomeEntries
        public ActionResult Index()
        {
            var incomeEntries = db.IncomeEntries.Include(i => i.StrAccountType);
            return View(incomeEntries.ToList());
        }

        // GET: IncomeEntries/Details/5
        public ActionResult DetailsIncome(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeEntry incomeEntry = db.IncomeEntries.Find(id);
            if (incomeEntry == null)
            {
                return HttpNotFound();
            }
            return View(incomeEntry);
        }

        // GET: IncomeEntries/Create
        public ActionResult CreateIncome()
        {
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName");
            return View();
        }

        // POST: IncomeEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateIncome([Bind(Include = "Id,AccountTypeID,AdoptionsDecimal,NumCatAdoptions,NumDogAdoptions,AdoptionsComment,DonationsDecimal,DonationsComment,MiscellaneousIncomeDecimal,MiscellaneousIncomeComment,EffectiveDate")] IncomeEntry incomeEntry)
        {
            if (ModelState.IsValid)
            {
                db.IncomeEntries.Add(incomeEntry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", incomeEntry.AccountTypeID);
            return View(incomeEntry);
        }

        // GET: IncomeEntries/Edit/5
        public ActionResult EditIncome(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeEntry incomeEntry = db.IncomeEntries.Find(id);
            if (incomeEntry == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", incomeEntry.AccountTypeID);
            return View(incomeEntry);
        }

        // POST: IncomeEntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditIncome([Bind(Include = "Id,AccountTypeID,AdoptionsDecimal,NumCatAdoptions,NumDogAdoptions,AdoptionsComment,DonationsDecimal,DonationsComment,MiscellaneousIncomeDecimal,MiscellaneousIncomeComment,EffectiveDate")] IncomeEntry incomeEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", incomeEntry.AccountTypeID);
            return View(incomeEntry);
        }

        // GET: IncomeEntries/Delete/5
        public ActionResult DeleteIncome(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeEntry incomeEntry = db.IncomeEntries.Find(id);
            if (incomeEntry == null)
            {
                return HttpNotFound();
            }
            return View(incomeEntry);
        }

        // POST: IncomeEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedIncome(int id)
        {
            IncomeEntry incomeEntry = db.IncomeEntries.Find(id);
            db.IncomeEntries.Remove(incomeEntry);
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
