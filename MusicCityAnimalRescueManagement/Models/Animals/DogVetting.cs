using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class DogVetting
    {
        [Required]
        public short id { get; set; }
        [Required]
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        /*Vetting*/
        
        [Display(Name = "Sterilized?")]
        public bool Sterilized { get; set; }
        [Display(Name = "Sterilization Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? SterilizationDate { get; set; }
        [Display(Name = "Sterilization Location")]
        public Location SterilizationLocation { get; set; }
        public int? SterilizationLocationId { get; set; }



        [Display(Name = "Bordetella?")]
        public bool Bordetella { get; set; }
        [Display(Name = "Bordetella Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? BordetellaDate { get; set; }
        [Display(Name = "Bordetella Vax Location")]
        public Location BordetellaLocation { get; set; }
        public int? BordetellaLocationId { get; set; }


        [Display(Name = "Rabies Vax?")]
        public bool Rabies { get; set; }
        [Display(Name = "Rabies Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RabiesDate { get; set; }
        [Display(Name = "Rabies Vax Location")]
        public Location RabiesLocation { get; set; }
        public int? RabiesLocationId { get; set; }
        public int? RabiesNumber { get; set; }


        [Display(Name = "Round One DA2PP?")]
        public bool DA2PPR1 { get; set; }
        [Display(Name = "Round One DA2PP Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DA2PPR1Date { get; set; }
        [Display(Name = "Round One DA2PP Vax Location")]
        public Location DA2PPR1Location { get; set; }
        public int? DA2PPR1LocationId { get; set; }



        [Display(Name = "Round Two DA2PP?")]
        public bool DA2PPR2 { get; set; }
        [Display(Name = "Round Two DA2PP Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DA2PPR2Date { get; set; }
        [Display(Name = "Round Two DA2PP Vax Location")]
        public Location DA2PPR2Location { get; set; }
        public int? DA2PPR2LocationId { get; set; }



        [Display(Name = "Round Three DA2PP?")]
        public bool DA2PPR3 { get; set; }
        [Display(Name = "Round Three DA2PP Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DA2PPR3Date { get; set; }
        [Display(Name = "Round Three DA2PP Vax Location")]
        public Location DA2PPR3Location { get; set; }
        public int? DA2PPR3LocationId { get; set; }



        [Display(Name = "Heartworm Tested?")]
        public bool HeartwormTested { get; set; }
        [Display(Name = "Heartworm Test Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? HeartwormDate { get; set; }
        [Display(Name = "Heartworm Test Location")]
        public Location HeartwormLocation { get; set; }
        public int? HeartwormLocationId { get; set; }

        [Display(Name = "Heartworm Positive?")]
        public bool HeartwormTestResult { get; set; }

        
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
        public int? FleaTickId { get; set; }
        [Display(Name = "Flea/Tick Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? FleaTickDate { get; set; }
        [Display(Name = "Flea/Tick Location")]
        public Location FleaTickLocation { get; set; }
        public int? FleaTickLocationId { get; set; }

        [Display(Name = "Microchip Number")]
        public long? MicrochipNumber { get; set; }
        public Location MicrochipLocation { get; set; }
        public Medication MicrochipManufacturer { get; set; }
        public int? MicrochipManufacturerId { get; set; }

        public int? MicrochipLocationId { get; set; }

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
        public DateTime? NextVet { get; set; }

        [Display(Name = "Vetting Completed")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? VettingCompleted { get; set; }

        [Display(Name = "Additional Comments")]
        [DataType(DataType.MultilineText)]
        public string AdtlComments { get; set; }

        [Display(Name = "Total Vetting Cost")]
        [DataType(DataType.Currency)]
        public decimal VettingTotalDecimal { get; set; }

        [Display(Name = "Cost of Most Recent Visit")]
        public decimal TempVettingDecimal { get; set; }
        [Display(Name = "Reason for Most Recent Visit")]
        public string ReasonForVisit { get; set; }
    }
}