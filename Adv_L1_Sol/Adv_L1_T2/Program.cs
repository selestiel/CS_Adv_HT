using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L1_T2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                MyClass<int>.FabricMethod();
                MyClass<char>.FabricMethod();
                MyClass<string>.FabricMethod();
                MyClass<double>.FabricMethod();

            }
            Console.ReadKey();
        }
    }
    class MyClass<T>
    {
        private string name { get; set; }
        public int count { get; set; }
        public T counts { get; set; }
        public T MSG()
        {
            Console.WriteLine("MESSAGE");
            return counts;
        }
        static public T FabricMethod()
        {
            MyClass<T> myClass = new MyClass<T>();
            myClass.name = ("Exemple" + myClass.count++);
            if (myClass.count < 5)
            {
                return FabricMethod();
            }
            else
            {
                return myClass.MSG();
            }
        }
    }
}
