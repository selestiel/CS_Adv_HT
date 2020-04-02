using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Attributes task 1
namespace Adv_L9_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("loki",99);
            
            myClass.Info();
            myClass.Info2();
            Console.ReadKey();
        }

    }
    public class MyClass
    {
        private string name { get; set; }
        private int age { get; set; }
        [Obsolete]
        public void Info()
        {
            Console.WriteLine(@"name {0} age {1}",name,age);
        }

        [Obsolete("OLD method implementation use new method please",true)]
        public void Info2()
        {
            Console.WriteLine("name2 " + name + " age2 " + age);
        }
        public MyClass(string n,int a)
        {
            name = n;
            age = a;
        }
    }
}
