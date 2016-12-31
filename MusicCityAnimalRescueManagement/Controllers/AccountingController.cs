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
using MusicCityAnimalRescueManagement.ViewModels;
using System.Dynamic;

namespace MusicCityAnimalRescueManagement.Controllers
{
    //[Authorize]
    public class AccountingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Entries()
        {
            dynamic entries = new ExpandoObject();
            entries.ExpenseEntries = GetExpenseEntries();
            entries.IncomeEntries = GetIncomeEntries();
            return View(entries);
        }

        public ActionResult Expenses()
        {
            var expenseEntries = db.ExpenseEntries.Include(e => e.StrAccountType);
            return View(expenseEntries.ToList());
        }

        public ActionResult Incomes()
        {
            var expenseEntries = db.IncomeEntries.Include(e => e.StrAccountType);
            return View(expenseEntries.ToList());
        }

        // GET: Accounting/Details/5
        public ActionResult DetailsExpense(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseEntry expenseEntry = db.ExpenseEntries.Find(id);
            if (expenseEntry == null)
            {
                return HttpNotFound();
            }
            return View(expenseEntry);
        }

        // GET: Accounting/Intake
        public ActionResult CreateExpense()
        {
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName");
            return View();
        }

        

        // POST: Accounting/Intake
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateExpense(ExpenseEntry expenseEntry)
        {
            if (ModelState.IsValid)
            {
                db.ExpenseEntries.Add(expenseEntry);
                db.SaveChanges();
                //return RedirectToAction("ListExpenses");
                return RedirectToAction("Entries");
            }

            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", expenseEntry.AccountTypeID);
            return View(expenseEntry);
        }

        // GET: Accounting/Edit/5
        public ActionResult EditExpense(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseEntry expenseEntry = db.ExpenseEntries.Find(id);
            if (expenseEntry == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", expenseEntry.AccountTypeID);
            return View(expenseEntry);
        }

        // POST: Accounting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditExpense(ExpenseEntry expenseEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expenseEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Entries");
            }
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", expenseEntry.AccountTypeID);
            return View(expenseEntry);
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
        public ActionResult CreateIncome(IncomeEntry incomeEntry)
        {
            if (ModelState.IsValid)
            {
                db.IncomeEntries.Add(incomeEntry);
                db.SaveChanges();
                return RedirectToAction("Entries");
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
        public ActionResult EditIncome(IncomeEntry incomeEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Entries");
            }
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", incomeEntry.AccountTypeID);
            return View(incomeEntry);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        public List<ExpenseEntry> GetExpenseEntries()
        {
            var expenseEntry = db.ExpenseEntries.Include(e => e.StrAccountType).ToList();
            return expenseEntry;
        }

        public List<IncomeEntry> GetIncomeEntries()
        {
            return db.IncomeEntries.ToList();
        }

        public ActionResult DeleteIncome(short? id)
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

        [HttpPost, ActionName("DeleteIncome")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteIncomeConfirmed(short id)
        {
            IncomeEntry incomeEntry = db.IncomeEntries.Find(id);
            db.IncomeEntries.Remove(incomeEntry);
            db.SaveChanges();
            return RedirectToAction("Entries");
        }
        public ActionResult DeleteExpense(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseEntry expenseEntry = db.ExpenseEntries.Find(id);
            if (expenseEntry == null)
            {
                return HttpNotFound();
            }
            return View(expenseEntry);
        }

        [HttpPost, ActionName("DeleteExpense")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteExpenseConfirmed(short id)
        {
            ExpenseEntry expenseEntry = db.ExpenseEntries.Find(id);
            db.ExpenseEntries.Remove(expenseEntry);
            db.SaveChanges();
            return RedirectToAction("Entries");
        }
    }
}
