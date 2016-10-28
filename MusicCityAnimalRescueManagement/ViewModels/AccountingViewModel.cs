using MusicCityAnimalRescueManagement.Models.AccountEntries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.ViewModels
{
    public class AccountingViewModel
    {
        public int id { get; set; }
        public IEnumerable<ExpenseEntry> ExpenseEntry { get; set; }
        public IEnumerable<IncomeEntry> IncomeEntry { get; set; }
        public string StrAccountType { get; set; }
    }
}