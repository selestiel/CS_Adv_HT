using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Adv_L5_T6
{
    class BikeDBContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeType> Types { get; set; }
        public BikeDBContext() 
            : base("name=BikeDBContext")
        {

        }
    }
}
