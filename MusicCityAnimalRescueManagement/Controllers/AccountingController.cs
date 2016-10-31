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

        // GET: Accounting
        public ActionResult Index()
        {
            //var expenseEntries = db.ExpenseEntries.Include(e => e.StrAccountType);
            //return View(expenseEntries.ToList());
            return View();
        }


        public ActionResult Entries()
        {
            dynamic Entries = new ExpandoObject();
            Entries.ExpenseEntries = GetExpenseEntries();
            Entries.IncomeEntries = GetIncomeEntries();
            return View(Entries);
        }

        public ActionResult ListExpenses()
        {
            var expenseEntries = db.ExpenseEntries.Include(e => e.StrAccountType);
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
        public ActionResult CreateExpense([Bind(Include = "Id,TimeStamp,EffectiveDate,AccountTypeID,SuppliesDecimal,SuppliesComment,VetBillsDecimal,VetBillsComment,MedicineDecimal,MedicineComment,InsurancePremiumsDecimal,InsurancePremiumsComment,FosterReimbursementDecimal,FosterReimbursementComment,MiscellaneousExpenseDecimal,MiscellaneousExpenseComment")] ExpenseEntry expenseEntry)
        {
            if (ModelState.IsValid)
            {
                db.ExpenseEntries.Add(expenseEntry);
                db.SaveChanges();
                return RedirectToAction("ListExpenses");
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
        public ActionResult EditExpense([Bind(Include = "Id,TimeStamp,EffectiveDate,AccountTypeID,SuppliesDecimal,SuppliesComment,VetBillsDecimal,VetBillsComment,MedicineDecimal,MedicineComment,InsurancePremiumsDecimal,InsurancePremiumsComment,FosterReimbursementDecimal,FosterReimbursementComment,MiscellaneousExpenseDecimal,MiscellaneousExpenseComment")] ExpenseEntry expenseEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expenseEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccountTypeID = new SelectList(db.AccountTypes, "AccountTypeID", "AccountTypeName", expenseEntry.AccountTypeID);
            return View(expenseEntry);
        }

        // GET: Accounting/Delete/5
        public ActionResult DeleteExpense(int? id)
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

        // POST: Accounting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedExpense(int id)
        {
            ExpenseEntry expenseEntry = db.ExpenseEntries.Find(id);
            db.ExpenseEntries.Remove(expenseEntry);
            db.SaveChanges();
            return RedirectToAction("Index");
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

        // GET: IncomeEntries/Createf
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


        public List<ExpenseEntry> GetExpenseEntries()
        {
            List<ExpenseEntry> ExpenseEntry = new List<ExpenseEntry>();
            ExpenseEntry = db.ExpenseEntries.Include(e => e.StrAccountType).ToList();
            return ExpenseEntry;
        }

        public List<IncomeEntry> GetIncomeEntries()
        {
            return db.IncomeEntries.ToList();
        }
    }
}
