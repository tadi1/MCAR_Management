using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MusicCityAnimalRescueManagement.Models
{
    public class Location
    {
        public int id { get; set; }
        [Display(Name = "Foster/Location Name")]
        public string name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

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
    }
}