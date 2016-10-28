using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Equipment
{
    public class InventoryItem
    {
        private int _itemNumber;
        public string itemnumberbuilder;
        
        public short id { get; set; }
        public string description { get; set; }
        public Location location { get; set; }

        public int ItemNumber
        {
            get { return _itemNumber; }
            set
            {
                itemnumberbuilder = location.id.ToString() + id;
                _itemNumber = Convert.ToInt32(itemnumberbuilder);
            }
        }
    }
}