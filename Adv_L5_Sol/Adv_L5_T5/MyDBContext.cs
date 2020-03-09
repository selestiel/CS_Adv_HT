using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Adv_L5_T5
{
    class MyDBContext : DbContext
    {
        public DbSet<MyClass1> class1s { get; set; }
        public DbSet<MyClass2> class2s { get; set; }
        public MyDBContext() 
            : base("name=MyDBContext")
        {
        }
    }
}
