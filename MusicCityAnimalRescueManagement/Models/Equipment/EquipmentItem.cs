using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicCityAnimalRescueManagement.Models.Equipment
{
    public class EquipmentItem
    {
        private int _itemNumber;
        public string itemnumberbuilder;
        
        public short id { get; set; }
        [Display (Name = "Item Description")]
        public string description { get; set; }

        [Display(Name = "Location")]
        public int LocationId { get; set; }

        [Display(Name = "Inventory Number")]
        [Editable(false)]
        public int ItemNumber { get; set; }

        public virtual Location Location { get; set; }
        //public int ItemNumber
        //{
        //    get { return _itemNumber; }
        //    set
        //    {
        //        itemnumberbuilder = location.id.ToString() + id;
        //        _itemNumber = Convert.ToInt32(itemnumberbuilder);
        //    }
        //}
    }
}