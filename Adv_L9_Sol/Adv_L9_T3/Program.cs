using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;

using MN = MyNamespace;
namespace Adv_L9_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            MN.MyClass myClass = new MyClass("Joined", 5);
            myClass.info();
            Console.ReadKey();
        }
    }
}

