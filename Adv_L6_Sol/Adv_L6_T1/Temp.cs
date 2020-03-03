using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _ITemp;
namespace Adv_L6_T1
{
    public class Temp : ITemp
    {
        public string TempName { get; set; }
        public double TempValue { get; set; }
        public void TempInfo()
        {
            Console.WriteLine(@"Temp: {0} Value {1}",TempName,TempValue);
        }
        public void Convert(string name_a,string name_b, double amount)
        {
            if(name_a == Celsius.name)
            {
                if (name_b == Kelvin.name)
                {
                    Kelvin.SetTemp(amount + 273.15);
                }
                else if (name_b == Fahrenheit.name)
                {
                    Fahrenheit.SetTemp(amount * 1.8 + 32);
                }
                else
                {
                    Console.WriteLine("Not implemented");
                }
                
            }
            else if (name_a == Kelvin.name)
            {
                if (name_b == Celsius.name)
                {
                    Celsius.SetTemp(amount - 273.15);
                }
                else if (name_b == Fahrenheit.name)
                {
                    Fahrenheit.SetTemp(amount * 1.8 - 459.67);
                }
                else
                {
                    Console.WriteLine("Not implemented");
                }

            }
            else if (name_a == Fahrenheit.name)
            {
                if (name_b == Kelvin.name)
                {
                    Kelvin.SetTemp((amount + 459.67) * 5 / 9);
                }
                else if (name_b == Celsius.name)
                {
                    Celsius.SetTemp((amount - 32) / 1.8);
                }
                else
                {
                    Console.WriteLine("Not implemented");
                }

            }
            else
            {
                Console.WriteLine("Not implemented");
            }
        }
        public void GetTemp(string name)
        {
            if(name == Celsius.name)
            {
                Console.WriteLine(@" Temperature: {0} current: {1} C"  ,Celsius.name,Celsius.GetTemp());
            }
            else if (name == Fahrenheit.name)
            {

                Console.WriteLine(@" Temperature: {0} current: {1} F", Fahrenheit.name, Fahrenheit.GetTemp());
            }
            else if (name == Kelvin.name)
            {

                Console.WriteLine(@" Temperature: {0} current: {1} K", Kelvin.name, Kelvin.GetTemp());
            }
            else
            {
                Console.WriteLine("Not implemented");
            }

        }
        public void SetTemp(string name, double amount)
        {
            if(name == Celsius.name)
            {
                Celsius.SetTemp(amount);
            }
            else if(name == Kelvin.name)
            {
                Kelvin.SetTemp(amount);
            }
            else if(name == Fahrenheit.name)
            {
                Fahrenheit.SetTemp(amount);
            }
            else
            {
                Console.WriteLine("Not implemented");
            }
        }
    }
}
