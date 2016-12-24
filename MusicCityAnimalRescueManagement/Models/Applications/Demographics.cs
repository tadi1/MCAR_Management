using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Applications
{
    public class Demographics
    {
        [Display(Name = "E-mail address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailAddress { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LName { get; set; }

        [Display(Name = "Driver's License Number")]
        [Required]
        public string DLNum { get; set; }

        [Display(Name = "Driver's License Expiration Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DLExp { get; set; }

        [Display(Name = "Street Address Line 1")]
        [Required]
        public string Address1 { get; set; }

        [Display(Name = "Street Address Line 2")]
        public string Address2 { get; set; }

        [Display(Name = "City, State")]
        [Required]
        public string CityState { get; set; }

        [Display(Name = "Zip Code")]
        [Required]
        public int ZipCode { get; set; }

        [Display(Name = "Home phone number")]
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [Display(Name = "Cell phone number")]
        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }

        [Display(Name = "Work phone number")]
        [DataType(DataType.PhoneNumber)]
        public string WorkPhone { get; set; }
    }


}