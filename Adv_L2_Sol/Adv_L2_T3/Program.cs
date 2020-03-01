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
            SortedList<int, string> SL = new SortedList<int, string>();
            SL.Add(0, "Word");
            SL.Add(1, "Sword");
            SL.Add(2, "World");
            SL.Add(3, "Worm");
            SL.Add(4, "Ward");
            SL.Add(5, "Lord");
            SL.Add(6, "War");
            SL.Add(7, "Marine");
            SL.Add(8, "Oranges");
            SL.Add(9, "Demigods");
            Console.WriteLine(new string('*',20));
            var list = from s in SL
                   orderby s.Key ascending
                   select s;
            foreach (var item in list)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('*',20));
            var list0 = from s in SL
                   orderby s.Key descending
                   select s;
            foreach (var item in list0)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('*',20));
            var list1 = from s in SL
                   orderby s.Value ascending
                   select s;
            foreach (var item in list1)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('*',20));
            var list2 = from s in SL
                   orderby s.Value descending
                   select s;
            foreach (var item in list2)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }



            Console.WriteLine();
            Console.ReadKey();
        }


    }
}
    
