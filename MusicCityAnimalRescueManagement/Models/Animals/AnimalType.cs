using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class AnimalTypes
    {
        public byte id { get; set; }
        [Display(Name = "Type")]
        public string AnimalTypeName { get; set; }
    }
}