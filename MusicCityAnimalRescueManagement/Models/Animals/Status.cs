using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Animals
{
    public class Status    
    {
        public short id { get; set; }
        public bool Adopted { get; set; }
        public bool ReadyForAdoption { get; set; }
    }
}