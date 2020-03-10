using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L9_T4
{
    public class BaseClass
    {
        public int ID { get; set; }
        public string name { get; set; }
        public void info()
        {
            Console.WriteLine(@"{0} {1}",name,ID);
        }
        public BaseClass()
        {
            ID = 3;
            name = "baseclassA";
        }
    }
}
