using System;
using Adv_L6_T1;

namespace Adv_L6_TM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Temp temp = new Temp();
            temp.SetTemp("Celsius", 70);
            temp.Convert("Celsius", "Kelvin", temp.TempValue);
            temp.Convert("Celsius", "Fahrenheit", temp.TempValue);

            temp.GetTemp("Kelvin");
            temp.GetTemp("Fahrenheit");
            temp.TempInfo();

            Temp temp1 = new Temp();
            Console.WriteLine(@" Temperatures implemented are:     Celsius     Kelvin     Fahrenheit     ");
            Console.WriteLine(" Enter temperature you want to Convert: ");
            string temps = Console.ReadLine();
            Console.WriteLine(" Enter amount of temperature to Convert: ");
            double nums = Convert.ToDouble(Console.ReadLine());
            
            temp.SetTemp(temps, nums);
            if (temps == "Celsius")
            {
                temp.Convert("Celsius", "Kelvin", temp.TempValue);
                temp.Convert("Celsius", "Fahrenheit", temp.TempValue);
            }
            else if(temps == "Kelvin")
            { 
                temp.Convert("Kelvin", "Celsius", temp.TempValue);
                temp.Convert("Kelvin", "Fahrenheit", temp.TempValue);
            }
            else if(temps == "Fahrenheit")
            {
                temp.Convert("Fahrenheit", "Celsius", temp.TempValue);
                temp.Convert("Fahrenheit", "Kelvin", temp.TempValue);
            }
            else
            {
                Console.WriteLine("Not yet Implemented!!!");
            }
            temp.GetTemp("Celsius");
            temp.GetTemp("Kelvin");
            temp.GetTemp("Fahrenheit");
            temp.TempInfo();

            Console.ReadKey();
        }
    }
}
