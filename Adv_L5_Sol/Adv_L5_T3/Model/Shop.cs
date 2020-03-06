using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L5_T3.Model
{
    public class Shop
    {
        public int shopID { get; set; }
        public string shopName { get; set; }
        public ICollection<Product> Product { get; set; }

        public Shop()
        {
            Product = new List<Product>();
        }
    }
}
