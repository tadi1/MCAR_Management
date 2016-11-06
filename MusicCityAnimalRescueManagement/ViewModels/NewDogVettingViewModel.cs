using MusicCityAnimalRescueManagement.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.ViewModels
{
    public class NewDogVettingViewModel
    {
        public DogVetting DogVetting { get; set; }
        public IEnumerable<Animal> Animals { get; set; }
        public Animal Animal { get; set; }
    }
}