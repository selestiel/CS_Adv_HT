using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adv_L5_T4
{
    public class CarColor
    {
        [Key]
        public int ColorID { get; set; }
        public string ColorName { get; set; }
        public virtual ICollection<CarType> Types { get; set; }
        public virtual ICollection<CarModel> Models { get; set; }
        public CarColor()
        {
            this.Types = new List<CarType>();
            this.Models = new List<CarModel>();
        }
    }
}
