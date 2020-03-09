using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L5_T6
{
    class BikeType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public Bike Bike { get; set; }
    }
}
