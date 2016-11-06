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
        [Display(Name = "Animal")]
        public int id { get; set; }

        [Required]
        [Display(Name = "MCAR ID")]
        public String MCARId { get; set; }

        //[Required]
        public AnimalTypes AnimalType { get; set; }

        [Required]
        [Display(Name = "Animal Type")]
        public byte AnimalTypeID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Years")]
        public string AgeY { get; set; }

        [Required]
        [Display(Name = "Months")]
        public string AgeM { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Intake Date")]
        public DateTime IntakeDate { get; set; }

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

        //[Required]
        public Location StrLocation { get; set; }

        [Required]
        [Display(Name = "Current Foster")]
        public int CurrentFosterID { get; set; }

        [Required]
        [Display(Name = "Pull Location")]
        public int PullLocationID { get; set; }
        public Location PullLocation { get; set; }


        //[Required]
        //[Display(Name = "Current Foster Name")]
        //public string CurrentFosterName { get; set; }

        public Location CurrentFoster { get; set; }

        [Required]
        [Display(Name = "Adopted?")]
        public bool Adopted { get; set; }

        [Required]
        [Display(Name = "Ready for adoption?")]
        public bool ReadyForAdoption { get; set; }

        [Display(Name = "Microchip Number")]
        public long MicrochipNumber { get; set; }

        [Display(Name = "Pull Fee")]
        [DataType(DataType.Currency)]
        public decimal? PullFee { get; set; }

        [Display(Name = "Adoption Fee")]
        [DataType(DataType.Currency)]
        public decimal? AdoptionFee { get; set; }

        [Required]
        [Display(Name = "Temperament")]
        public string Temperament { get; set; }

        [Required]
        [Display(Name = "Additional Comments")]
        public string AdtlComments{ get; set; }

    }
}