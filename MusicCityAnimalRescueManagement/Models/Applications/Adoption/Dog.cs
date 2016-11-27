using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MusicCityAnimalRescueManagement.Models.Animals;

namespace MusicCityAnimalRescueManagement.Models.Applications.Adoption
{
    public class Dog
    {
        #region Applicant Information
        [Required]
        [Display (Name="First Name")]
        public string FName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required]
        [Display(Name = "E-mail Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driver's License Number")]
        public string DlNum { get; set; }

        [Required]
        [Display(Name = "Driver's License Expiration Date")]
        public DateTime DlExpiration { get; set; }

        [Required]
        [Display(Name = "Street Address Line 1")]
        public string StreetAddressLine1 { get; set; }

        [Display(Name = "Street Address Line 2")]
        public string StreetAddressLine2 { get; set; }

        [Required]
        [Display(Name = "City, State")]
        public string CityState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Phone Number")]
        public string HomePhoneNumber { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Cell Phone Number")]
        public string CellPhoneNumber { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Work Phone Number")]
        public string WorkPhoneNumber { get; set; }
        #endregion Applicant Information

        #region Animal Information
        public Animal Animal { get; set; }

        [Required]
        [Display(Name = "Which animal are you applying to adopt")]
        public int AnimalId { get; set; }

        [Required]
        [Display(Name = "Description of the animal")]
        public int AnimalDescription { get; set; }
        #endregion

        #region Residence Information

        public string AdditionalInfo { get; set; }
        
        [Required]
        [Display(Name = "Do you currently own any pets?")]
        public bool OwnPets { get; set; }
        
        [Display(Name = "If yes, what type and how many pets?")]
        public string CurrentPets { get; set; }
        
        [Display(Name = "If so, from who did you adopt?")]
        public string AdoptedFrom { get; set; }

        [Display(Name = "If you have a fence, approximately how tall is it (in feet)?")]
        public decimal FenceHeightDecimal { get; set; }

        #endregion

        #region Current Pets

        [Required]
        [Display (Name = "How many pets do you currently own?")]    
        public int NumCurrentPets { get; set; } 

        

        #endregion
    }
}