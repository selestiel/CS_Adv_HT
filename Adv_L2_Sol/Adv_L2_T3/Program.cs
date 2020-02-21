using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L2_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Adic.Add(0,"Word");
            mc.Adic.Add(1, "Sword");
            mc.Adic.Add(2, "World");
            mc.Adic.Add(3, "Worm");
            mc.Adic.Add(4, "Ward");
            mc.Adic.Add(5, "Lord");
            mc.Adic.Add(6, "War");
            mc.Adic.Add(7, "Marine");
            mc.Adic.Add(8, "Oranges");
            mc.Adic.Add(9, "Demigods");
            
        }
        

    }
    class MyClass
    {
        public Dictionary<int, string> Adic = new Dictionary<int, string> {};

    }
}
