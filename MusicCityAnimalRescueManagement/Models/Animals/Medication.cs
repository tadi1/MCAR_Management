using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class Medication
    {
        public short id { get; set; }

        public String Name { get; set; }

        [Display(Name = "Flea/Tick?")]
        public bool isFleaTick { get; set; }

        [Display(Name = "Heartworm?")]
        public bool isHeartworm { get; set; }

        [Display(Name = "For Cats?")]
        public bool isForCats { get; set; }


        [Display(Name = "For Dogs?")]
        public bool isForDogs { get; set; }
    }
}