using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adv_L9_T4;
namespace Adv_L9_T4a
{
    class DerivedClass : Adv_L9_T4.BaseClass
    {
        public string name { get; set; }
        public int id { get; set; }
        public void info2()
        {
            Console.WriteLine(@"{0}  {1}",name,id);
        }
        public DerivedClass()
        {
            name = "DerivedClass";
            id = 90;
        }
    }
}
