using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.Equipment;

namespace MusicCityAnimalRescueManagement.ViewModels
{
    public class EquipmentViewModel
    {
        public int id { get; set; }
        public EquipmentItem EquipmentItem { get; set; }
        //public Location ItemLocation { get; set; }
        public IEnumerable<Location> Locations { get; set; }
    }
}