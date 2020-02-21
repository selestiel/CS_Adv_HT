using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L4_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Enter operation:");
            string oper = Console.ReadLine();
            Console.WriteLine("Enter argument X: ");
            dynamic X = Console.ReadLine();
            Console.WriteLine("Enter argument Y: ");
            dynamic Y = Console.ReadLine();
            switch (oper)
            {
                case "add":
                    dynamic result1 = calc.Add(X, Y);
                    Console.WriteLine("Result: {}",result1);
                    break;
                case "mul":
                    dynamic result2 = calc.Mul(X, Y);
                    Console.WriteLine("Result: {}", result2);
                    break;
                case "sub":
                    dynamic result3 = calc.Sub(X, Y);
                    Console.WriteLine("Result: {}", result3);
                    break;
                case "div":
                    dynamic result4 = calc.Div(X, Y);
                    Console.WriteLine("Result: {}", result4);
                    break;
                case "par":
                    dynamic result5 = calc.Par(X, Y);
                    Console.WriteLine("Result: {}", result5);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public dynamic Add(dynamic arg1, dynamic arg2)
        {
            return arg1 + arg2;
        }
        public dynamic Mul(dynamic arg1, dynamic arg2)
        {
            return arg1 * arg2;
        }
        public dynamic Sub(dynamic arg1, dynamic arg2)
        {
            return arg1 - arg2;
        }
        public dynamic Div(dynamic arg1, dynamic arg2)
        {
            return arg2==0 ? "Cant divide by 0" : arg1 / arg2;
        }
        public dynamic Par(dynamic arg1, dynamic arg2)
        {
            return arg2 == 0 ? "Cant divide by 0" : arg1 % arg2;
        }
        

    }
}
