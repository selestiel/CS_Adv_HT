using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L1_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int, int> calc = new Calculator<int, int>();
            Console.WriteLine(calc.Addition(250, 500));
            Console.WriteLine(calc.Substraction(250, 500));
            Console.WriteLine(calc.Multiplication(250, 500));
            Console.WriteLine(calc.Dividing(250, 500));
            Console.WriteLine(new string('-',10));
            Calculator<string, int> calcs = new Calculator<string, int>();
            Console.WriteLine(calcs.Addition("250", 500));
            Console.WriteLine(calcs.Substraction("250", 500));
            Console.WriteLine(calcs.Multiplication("250", 500));
            Console.WriteLine(calcs.Dividing("250", 500));

            Console.ReadKey();
        }
    }
    class Calculator<T, R>
    {
        public double Addition(T value_1, R value_2)
        {
            double sum = Convert.ToDouble(value_1) + Convert.ToDouble(value_2);
            return sum;
        }
        public double Substraction(T value_1, R value_2)
        {
            double sum = Convert.ToDouble(value_1) - Convert.ToDouble(value_2);
            return sum;
        }
        public double Multiplication(T value_1, R value_2)
        {
            double sum = Convert.ToDouble(value_1) * Convert.ToDouble(value_2);
            return sum;
        }
        public double Dividing(T value_1, R value_2)
        {
            double sum = Convert.ToDouble(value_1) / Convert.ToDouble(value_2);
            return sum;
        }
    }
}
