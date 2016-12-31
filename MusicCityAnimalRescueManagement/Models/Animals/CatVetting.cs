using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class CatVetting
    {
        [Required]
        public short id { get; set; }
        [Required]
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        /*Vetting*/

        [Display(Name = "Microchip Number")]
        public long MicrochipNumber { get; set; }
        [Display(Name = "Microchip Location")]
        public Location MicrochipLocation { get; set; }
        [Display(Name = "Microchip Manufacturer")]
        public int? MicrochipLocationId { get; set; }
        [Display(Name = "Microchip Manufacturer")]

        public Medication MicrochipManufacturer { get; set; }
        [Display(Name = "Microchip Manufacturer")]
        public int? MicrochipManufacturerId { get; set; }

        [Display(Name = "Sterilized?")]
        public bool Sterilized { get; set; }
        [Display(Name = "Sterilization Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? SterilizationDate { get; set; }
        [Display(Name = "Sterilization Location")]
        public Location SterilizationLocation { get; set; }
        public int? SterilizationLocationId { get; set; }


        [Display(Name = "Rabies Vax?")]
        public bool Rabies { get; set; }
        [Display(Name = "Rabies Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RabiesDate { get; set; }
        [Display(Name = "Rabies Vax Location")]
        public Location RabiesLocation { get; set; }
        public int? RabiesLocationId { get; set; }



        [Display(Name = "FVRCP Round 1?")]
        public bool FVRCP1 { get; set; }
        [Display(Name = "FVRCP Round 1 Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FVRCP1Date { get; set; }
        [Display(Name = "FVRCP Round 1 Location")]
        public Location FVRCP1Location { get; set; }
        public int? FVRCP1LocationId { get; set; }

        [Display(Name = "FVRCP Round 2?")]
        public bool FVRCP2 { get; set; }
        [Display(Name = "FVRCP Round 2 Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FVRCP2Date { get; set; }
        [Display(Name = "FVRCP Round 2 Location")]
        public Location FVRCP2Location { get; set; }
        public int? FVRCP2LocationId { get; set; }

        
        [Display(Name = "FVRCP Round 3?")]
        public bool FVRCP3 { get; set; }
        [Display(Name = "FVRCP Round 3 Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FVRCP3Date { get; set; }
        [Display(Name = "FVRCP Round 3 Location")]
        public Location FVRCP3Location { get; set; }
        public int? FVRCP3LocationId { get; set; }

        [Display(Name = "FVRCP Due")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FVRCP3Due { get; set; }

        [Display(Name = "Dewormer used?")]
        public Medication Dewormer { get; set; }
        [Display(Name = "Dewormer Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DewormerDate { get; set; }
        [Display(Name = "Dewormer Location")]
        public Location DewormerLocation { get; set; }
        public int? DewormerLocationId { get; set; }

        [Display(Name = "Flea/Tick used?")]
        public Medication FleaTick { get; set; }
        [Display(Name = "Flea/Tick Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FleaTickDate { get; set; }
        [Display(Name = "Flea/Tick Location")]
        public Location FleaTickLocation { get; set; }
        public int? FleaTickLocationId { get; set; }

        [Display(Name = "FEV/Leuk Tested?")]
        public bool FEVLeukTested { get; set; }
        [Display(Name = "FEV/Leuk Test Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FEVLeukDate { get; set; }
        public Location FEVLeukLocation { get; set; }
        [Display(Name = "FEV/Leuk Test Location")]
        public int? FEVLeukId { get; set; }

        [Display(Name = "FEV/Leuk Positive?")]
        public bool FEVLeukResult { get; set; }

        [Display(Name = "Additional Vetting")]
        public bool AddtlVetting { get; set; }

        [Display(Name = "Vet Diagnosis")]
        [DataType(DataType.MultilineText)]
        public string VetDiagnosis { get; set; }

        [Display(Name = "Vet Diagnosis Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? VetDiagnosisDate { get; set; }
        [Display(Name = "Medications Given")]
        [DataType(DataType.MultilineText)]
        public string MedicationsGiven { get; set; }

        [Display(Name = "Next Vet Appointment")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime?NextVet { get; set; }

        [Display(Name = "Vetting Completed")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime?VettingCompleted { get; set; }

        [Display(Name = "Additional Comments")]
        [DataType(DataType.MultilineText)]
        public string AdtlComments { get; set; }

        [Display(Name = "Total Vetting Cost")]
        [DataType(DataType.Currency)]
        public decimal VettingTotalDecimal{ get; set; }

        [Display(Name = "Cost of Most Recent Visit")]
        public decimal TempVettingDecimal { get; set; }
        [Display(Name = "Reason for Most Recent Visit")]
        public string ReasonForVisit { get; set; }
    }
}