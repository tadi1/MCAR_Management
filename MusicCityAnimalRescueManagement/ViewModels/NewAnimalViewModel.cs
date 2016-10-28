using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.Animals;

namespace MusicCityAnimalRescueManagement.ViewModels
{
    public class NewAnimalViewModel
    {
        public int id { get; set; }
        public IEnumerable<Location> Locations { get; set; }

        //public IEnumerable<AnimalTypes> AnimalTypes { get; set; }
        public IEnumerable<AnimalTypes> AnimalTypes { get; set; }
        public Animal Animal { get; set; }
    }
}