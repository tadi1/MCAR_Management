using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class Animal
    {
        [Required]
        [Display(Name = "MCAR ID")]
        public int id { get; set; }

        [Required]
        [Display(Name = "Animal Type")]
        //public short AnimalTypeID { get; set; }
        public AnimalTypes  AnimalType { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Coloration/Pattern")]
        public string colors { get; set; }

        [Required]
        [Display(Name = "Breed")]
        public string breed { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Required]
        [Display(Name = "House/Litter Box Trained?")]
        public bool housetraining { get; set; }

        [Required]
        [Display(Name = "Current Foster")]
        //public int LocationID { get; set; }
        public Location Location { get; set; }

        [Required]
        [Display(Name = "Adopted?")]
        public bool adopted { get; set; }
    }
}