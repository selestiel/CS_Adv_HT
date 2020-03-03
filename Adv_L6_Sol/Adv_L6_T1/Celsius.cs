using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L6_T1
{
    public class Celsius : Temp
    {
        public const string name = "Celsius";
        private static double amount { get; set; }
        public static double GetTemp()
        {
            return amount;
        }
        public static void SetTemp(double value)
        {
            amount = value;
        }
    }
}
