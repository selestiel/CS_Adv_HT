using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Adv_L5_T4
{
    class CarDBContext : DbContext
    {
        public DbSet<CarType> Types { get; set; }
        public DbSet<CarModel> Models { get; set; }
        public DbSet<CarColor> Colors { get; set; }
        public CarDBContext() 
            : base("name=CarDBContext")
        {
        }
    }
}
