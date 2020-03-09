using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adv_L5_T4
{
    public class CarModel
    {
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public virtual ICollection<CarType> Types { get; set; }
        public virtual ICollection<CarColor> Colors { get; set; }
        public CarModel()
        {
            this.Types = new List<CarType>();
            this.Colors = new List<CarColor>();
        
        }
    }
}
