using MusicCityAnimalRescueManagement.Models;
using MusicCityAnimalRescueManagement.Models.Animals;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.ViewModels
{
    public class NewCatVettingViewModel
    {
        public int id { get; set; }
        public CatVetting CatVetting { get; set; }
        public IEnumerable<Animal> Animals { get; set; }
        public IEnumerable<Location> BasicVaxLocations { get; set; }
        public IEnumerable<Location> RabiesLocations { get; set; }
        public IEnumerable<Medication> MicrochipManufactures { get; set; }

        public IEnumerable<Medication> Meds { get; set; }

        public Animal Animal { get; set; }

        //public override string ToString()
        //{
        //    return Animals.
        //}
    }
}