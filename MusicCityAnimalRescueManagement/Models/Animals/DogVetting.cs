using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class DogVetting
    {
        [Required]
        public short id { get; set; }
        [Required]
        public int AnimalsID { get; set; }
        public Animal Animal { get; set; }

        /*Vetting*/
        [Required]
        [Display(Name = "Sterilized?")]
        public bool Sterilized { get; set; }
        [Display(Name = "Sterilization Date")]
        public DateTime SterilizationDate { get; set; }
        [Display(Name = "Sterilization Location")]
        public Location SterilizationLocation { get; set; }

        [Required]
        [Display(Name = "Rabies?")]
        public bool Rabies { get; set; }
        [Display(Name = "Rabies Date")]
        public DateTime RabiesDate { get; set; }
        [Display(Name = "Rabies Location")]
        public Location RabiesLocation { get; set; }

        [Required]
        [Display(Name = "Round One DA2PP?")]
        public bool DA2PPR1 { get; set; }
        [Display(Name = "Round One DA2PP Date")]
        public DateTime DA2PPR1Date { get; set; }
        [Display(Name = "Round One DA2PP Location")]
        public Location DA2PPR1Location { get; set; }

        [Required]
        [Display(Name = "Round Two DA2PP?")]
        public bool DA2PPR2 { get; set; }
        [Display(Name = "Round Two DA2PP Date")]
        public DateTime DA2PPR2Date { get; set; }
        [Display(Name = "Round Two DA2PP Location")]
        public Location DA2PPR2Location { get; set; }

        [Required]
        [Display(Name = "Round Three DA2PP?")]
        public bool DA2PPR3 { get; set; }
        [Display(Name = "Round Three DA2PP Date")]
        public DateTime DA2PPR3Date { get; set; }
        [Display(Name = "Round Three DA2PP Location")]
        public Location DA2PPR3Location { get; set; }

        [Required]
        [Display(Name = "Heartworm Tested?")]
        public bool HeartwormTested { get; set; }
        [Display(Name = "Heartworm Test Date")]
        public DateTime HeartwormDate { get; set; }
        [Display(Name = "Heartworm Test Location")]
        public Location HeartwormLocation { get; set; }

        [Required]
        [Display(Name = "Dewormer used?")]
        public Medication Dewormer { get; set; }
        [Display(Name = "Dewormer Date")]
        public DateTime DewormerDate { get; set; }

    }
}