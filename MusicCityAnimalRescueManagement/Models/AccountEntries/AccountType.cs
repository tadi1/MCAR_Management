using System;
using System.ComponentModel.DataAnnotations;

namespace MusicCityAnimalRescueManagement.Models.AccountEntries
{
    public class AccountType    
    {
        [Display(Name = "Account")]
        public byte AccountTypeID { get; set; }
        [Display(Name = "Account")]
        public String AccountTypeName { get; set; }
    }
}