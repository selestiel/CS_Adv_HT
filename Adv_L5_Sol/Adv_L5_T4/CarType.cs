using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adv_L5_T4
{
    public class CarType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<CarModel> Models { get; set; }
        public virtual ICollection<CarColor> Colors { get; set; }
        public CarType()
        {
            this.Models = new List<CarModel>();
            this.Colors = new List<CarColor>();
        }
    }
}
