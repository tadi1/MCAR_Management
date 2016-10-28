using System;
using System.ComponentModel.DataAnnotations;

namespace MusicCityAnimalRescueManagement.Models.AccountEntries
{
    [MetadataType(typeof(IncomeEntryMetadata))]
    public partial class IncomeEntry
    {
    }

    public partial class IncomeEntryMetadata
    {
        [Display(Name = "StrAccountType")]
        public AccountType StrAccountType { get; set; }

        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "AccountTypeID")]
        public byte AccountTypeID { get; set; }

        [Display(Name = "AdoptionsDecimal")]
        public decimal AdoptionsDecimal { get; set; }

        [Display(Name = "NumCatAdoptions")]
        public int NumCatAdoptions { get; set; }

        [Display(Name = "NumDogAdoptions")]
        public int NumDogAdoptions { get; set; }

        [Display(Name = "AdoptionsComment")]
        public string AdoptionsComment { get; set; }

        [Display(Name = "DonationsDecimal")]
        public decimal DonationsDecimal { get; set; }

        [Display(Name = "DonationsComment")]
        public string DonationsComment { get; set; }

        [Display(Name = "MiscellaneousIncomeDecimal")]
        public decimal MiscellaneousIncomeDecimal { get; set; }

        [Display(Name = "MiscellaneousIncomeComment")]
        public string MiscellaneousIncomeComment { get; set; }

        [Required(ErrorMessage = "Please enter : EffectiveDate")]
        [Display(Name = "EffectiveDate")]
        public DateTime EffectiveDate { get; set; }

    }
}
