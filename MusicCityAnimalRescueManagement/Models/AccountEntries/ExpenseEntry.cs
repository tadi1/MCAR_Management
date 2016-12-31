using System;
using System.ComponentModel.DataAnnotations;

namespace MusicCityAnimalRescueManagement.Models.AccountEntries
{
    public class ExpenseEntry
    {
        
        /* Helper property variables */
        private decimal? _suppliesDecimal;
        private decimal? _vetBillsDecimal;
        private decimal? _medicineDecimal;
        private decimal? _insurancePremiumsDecimal;
        private decimal? _fosterReimbursementDecimal;
        private decimal? _miscellaneousExpenseDecimal;
        private decimal? _PullFeeDecimal;


        /* Housekeeping? */
        [Required]
        [Display(Name = "Entry ID")]
        public int Id { get; set; }
        //[Display(Name = "Which Account?")]
        public AccountType StrAccountType { get; set; }

        [Required]
        [Display(Name = "Which Account?")]
        public byte AccountTypeID { get; set; }


        /* Expense "line" items */
        [Display(Name = "Supplies Amount")]
        [DataType(DataType.Currency)]
        public decimal? SuppliesDecimal
        {
            get { return _suppliesDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _suppliesDecimal = -1*value;
                else
                    _suppliesDecimal = value;
            }
        }
        [Display(Name = "Supplies Comment")]
        public string SuppliesComment { get; set; }

        [Display(Name = "Vet Bills Amount")]
        [DataType(DataType.Currency)]
        public decimal? VetBillsDecimal
        {
            get { return _vetBillsDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _vetBillsDecimal = -1*value;
                else
                    _vetBillsDecimal = value;
            }
        }
        [Display(Name = "Vet Bills Comment")]
        public string VetBillsComment { get; set; }

        [Display(Name = "Medicine Amount")]
        [DataType(DataType.Currency)]
        public decimal? MedicineDecimal
        {
            get { return _medicineDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _medicineDecimal = -1*value;
                else
                    _medicineDecimal = value;
            }
        }

        [Display(Name = "Medicine Comment")]
        public string MedicineComment { get; set; }

        [Display(Name = "Foster Reimbursement  Amount")]
        [DataType(DataType.Currency)]
        public decimal? InsurancePremiumsDecimal
        {
            get { return _insurancePremiumsDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _insurancePremiumsDecimal = -1 * value;
                else
                    _insurancePremiumsDecimal = value;
            }
        }

        [Display(Name = "Foster Reimbursement  Comment")]
        public string InsurancePremiumsComment { get; set; }

        [Display(Name = "Insurance Premiums Amount")]
        [DataType(DataType.Currency)]
        public decimal? FosterReimbursementDecimal
        {
            get { return _fosterReimbursementDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _fosterReimbursementDecimal = -1*value;
                else
                    _fosterReimbursementDecimal = value;
            }
        }

        [Display(Name = "Insurance Premiums Comment")]
        public string FosterReimbursementComment { get; set; }

        [Display(Name = "Miscellaneous Amount")]
        [DataType(DataType.Currency)]
        public decimal? MiscellaneousExpenseDecimal
        {
            get { return _miscellaneousExpenseDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _miscellaneousExpenseDecimal = -1*value;
                else
                    _miscellaneousExpenseDecimal = value;
            }
        }

        [Display(Name = "Miscellaneous Comment")]
        public string MiscellaneousExpenseComment { get; set; }

        [Display(Name = "Pull Fee Amount")]
        [DataType(DataType.Currency)]
        public decimal? PullFeeDecimal
        {
            get { return _PullFeeDecimal; }
            set
            {
                if (value.HasValue && value > 0)
                    _PullFeeDecimal = -1*value;
                else
                    _PullFeeDecimal = value;
            }
        }
        [Display(Name = "Pull Fee Comment")]
        public string PullFeeComment { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Effective Date")]
        public DateTime? EffectiveDate { get; set; }
    }
}