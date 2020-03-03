using System;
using Adv_L6_T1;

namespace Adv_L6_TM
{
    class Program
    {
        static void Main(string[] args)
        {
            Temp temp = new Temp();
            temp.SetTemp("Celsius", 70);
            temp.Convert("Celsius", "Kelvin", temp.TempValue);
            temp.Convert("Celsius", "Fahrenheit", temp.TempValue);

            temp.GetTemp("Kelvin");
            temp.GetTemp("Fahrenheit");
            temp.TempInfo();
            Console.ReadKey();
        }
    }
}
