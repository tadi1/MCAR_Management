using System;
using System.ComponentModel.DataAnnotations;

namespace MusicCityAnimalRescueManagement.Models.AccountEntries
{
    public partial class IncomeEntry
    {
        /* Helper property variables */
        private decimal? _adoptionsDecimal;
        private decimal? _donationsBillsDecimal;
        private decimal? _miscellaneousIncomeDecimal;


        /* Housekeeping? */
        [Required]
        [Display(Name = "Entry ID")]
        public int Id { get; set; }
        //[Display(Name = "Which Account?")]
        public AccountType StrAccountType { get; set; }

        [Required]
        [Display(Name = "Which Account?")]
        public byte AccountTypeID { get; set; }


        /* Income "line" items */
        [Display(Name = "Adoptions Amount")]
        [DataType(DataType.Currency)]
        public decimal? AdoptionsDecimal
        {
            get { return _adoptionsDecimal; }
            set
            {
                if (value.HasValue && value < 0)
                    _adoptionsDecimal = -1 * value;
                else
                    _adoptionsDecimal = value;
            }
        }
        [Display(Name = "Number of cat adoptions")]
        public int NumCatAdoptions { get; set; }

        [Display(Name = "Number of dog adoptions")]
        public int NumDogAdoptions { get; set; }

        [Display(Name = "Additional adoptions Comment")]
        public string AdoptionsComment { get; set; }

        [Display(Name = "Donations Amount")]
        [DataType(DataType.Currency)]
        public decimal? DonationsDecimal
        {
            get { return _donationsBillsDecimal; }
            set
            {
                if (value.HasValue && value < 0)
                    _donationsBillsDecimal = -1 * value;
                else
                    _donationsBillsDecimal = value;
            }
        }
        [Display(Name = "Donations Comment")]
        public string DonationsComment { get; set; }

        [Display(Name = "Miscellaneous Amount")]
        [DataType(DataType.Currency)]
        public decimal? MiscellaneousIncomeDecimal
        {
            get { return _miscellaneousIncomeDecimal; }
            set
            {
                if (value.HasValue && value < 0)
                    _miscellaneousIncomeDecimal = -1 * value;
                else
                    _miscellaneousIncomeDecimal = value;
            }
        }
        [Display(Name = "Miscellaneous Comment")]
        public string MiscellaneousIncomeComment { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Effective Date")]
        public DateTime? EffectiveDate { get; set; }
    }
}