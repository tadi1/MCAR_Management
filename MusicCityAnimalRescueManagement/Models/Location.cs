﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MusicCityAnimalRescueManagement.Models
{
    public class Location
    {
        public int id { get; set; }

        //[Required]
        [Display(Name = "Foster/Location")]
        public string name { get; set; }

        [Display(Name = "Contact (Not for fosters)")]
        public string Contacts { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City, State Zip")]
        public string City { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Provided phone number not valid")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Notes")]
        public String Notes { get; set; }

        [Display(Name = "Cats")]
        public bool Cats { get; set; }

        [Display(Name = "Dogs")]
        public bool Dogs { get; set; }

        [Display(Name = "Active?")]
        public bool isActive { get; set; }

        [Display(Name = "Foster?")]
        public bool isFoster { get; set; }

        [Display(Name = "Pull location?")]
        public bool isPullLocation { get; set; }

        [Display(Name = "Adoption Venue?")]
        public bool isAdoptionVenue { get; set; }

        [Display(Name = "Provides basic vaxination?")]
        public bool isBasicVaxLocation { get; set; }

        [Display(Name = "Provides rabies vaccinations?")]
        public bool isRabiesVaxLocation { get; set; }


        [Display(Name = "DO NOT DISPLAY ME")]
        public bool isShowLast { get; set; }

    }
}