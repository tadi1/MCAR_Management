using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MusicCityAnimalRescueManagement.Models.AccountEntries
{
    [Obsolete]
    public class Entry
    { 
        [Required]
        public int Id { get; set; }
        [Display(Name = "Account")]
        [Required]
        public DateTime? TimeStamp { get; set; }
        public DateTime? EffectiveDate { get; set; }
        [Display(Name = "Which Account?")]
        public AccountType StrAccountType { get; set; }
        public byte AccountTypeID { get; set; }

    }
}