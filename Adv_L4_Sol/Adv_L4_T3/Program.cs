using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L4_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> col = new List<int>();
            List<int> colp = new List<int>();
            List<int> colm = new List<int>();
            for (int i=0; i<30;i++)
            {
                col.Add(rnd.Next(-100, 100));
            }
            foreach (var item in col)
            {
                if (item > 0)
                {
                    colp.Add(item);
                }
                if(item <= 0)
                {
                    colm.Add(item);
                }
            }
            Console.WriteLine(@"First positive: {0} Last Negative {1}", colp.First(), colm.Last());
            foreach (var item in col)
            {
            Console.Write(" " + item);

            }
            Console.ReadKey();
        }
    }
}
