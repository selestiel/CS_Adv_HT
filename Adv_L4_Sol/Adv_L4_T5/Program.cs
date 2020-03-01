using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L4_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<dynamic, dynamic> Dic = new Dictionary<dynamic, dynamic>()
            {
               {"Warm" , "Тепло"},
               {"Heat" , "Жара"},
               {"Weather" , "Погода"},
               {"Sun" , "Солнце"},
               {"Cloud" , "Облако"},
               {"Rain" , "Дождь"},
               {"Snow" , "Снег"},
               {"Cold" , "Холодно"},
               {"Winter" , "Зима"},
               { "Moon" , "Луна"}

            };

            foreach (var item in Dic)
	        {
                Console.WriteLine(@"{0} = {1}",item.Key,item.Value);
	        }
            Console.WriteLine(  );
            Console.ReadKey();
        }
    }
}
