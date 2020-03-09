using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L5_T6
{
    class Bike
    {
        [Key]
        public int bikeID { get; set; }
        public string bikeName { get; set; }
        public int bikeCount { get; set; }
        public virtual ICollection<BikeType> bikeType { get; set; }
        public Bike()
        {
            bikeType = new List<BikeType>();
        }
    }
}
