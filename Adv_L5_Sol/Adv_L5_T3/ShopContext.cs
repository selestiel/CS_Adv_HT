using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L5_T3.Model
{
    public class ShopContext : DbContext
    {
        public virtual DbSet<Shop> shops { get; set; }
        public virtual DbSet<Product> products { get; set; }
        public ShopContext()
            : base("name=SETSHOPS")
        {

        }
    }
}
