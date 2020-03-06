using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L5_T3.Model
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string ProductType { get; set; }
        public Shop shop { get; set; }
    }
}
