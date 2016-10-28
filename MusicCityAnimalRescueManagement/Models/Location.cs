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
        [Display(Name = "Location")]
        public string name { get; set; }
        public bool isActive { get; set; }
    }
}