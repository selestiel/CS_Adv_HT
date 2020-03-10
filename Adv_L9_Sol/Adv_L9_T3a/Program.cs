using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L9_T3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working");
        }
    }
}
namespace MyNamespace
{
    public class MyClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void info()
        {
            Console.WriteLine(@"{0} {1}",Name,ID);
        }
        public MyClass(string n, int i)
        {
            Name = n;
            ID = i;
        }
    }
}
