using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L3_T2
{
    delegate int lambda(int arg1, int arg2);
    class Program
    {
        static void Main(string[] args)
        {
            string oper = "";
            Console.WriteLine("Enter your operation:");
            oper = Console.ReadLine();
            Console.WriteLine("Enter your arguments: X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            switch (oper)
            {
                case "add":
                    lambda lam1 = (int arg1, int arg2) => arg1 + arg2;
                    int lam1res = lam1(x, y);
                    Console.WriteLine(lam1res);
                    break;
                case "mul":
                    lambda lam2 = (int arg1, int arg2) => arg1 * arg2;
                    int lam2res = lam2(x, y);
                    Console.WriteLine(lam2res);
                    break;
                case "sub":
                    lambda lam3 = (int arg1, int arg2) => arg1 - arg2;
                    int lam3res = lam3(x, y);
                    Console.WriteLine(lam3res);
                    break;
                case "div":
                    lambda lam4 = (int arg1, int arg2) => arg2==0 ? 0 : arg1 / arg2;
                    int lam4res = lam4(x, y);
                    Console.WriteLine(lam4res);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
