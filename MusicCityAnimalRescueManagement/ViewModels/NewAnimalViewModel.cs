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
        public IEnumerable<Location> FosterLocations { get; set; }
        public IEnumerable<Location> PullLocations { get; set; }
        public IEnumerable<AnimalTypes> AnimalTypes { get; set; }
        public IEnumerable<Sex> Sexes { get; set; }
        public Animal Animal { get; set; }
        public string StrAnimalType { get; set; }

    }
}