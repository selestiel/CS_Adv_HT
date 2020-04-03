using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adv_L12_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { };
            Array(ref arr);
            var plinq = from int number in arr.AsParallel() where (number % 2 != 0) select number;
            foreach (var item in plinq)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
        static int[] Array(ref int[] arr)
        {
            arr = new int[1000000];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 1000000);
            }
            return arr;
        }
    }
}
