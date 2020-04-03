using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L12_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncCallback Callback = new AsyncCallback(IAsyncResult => Info());
            Action action = new Action(Info);
            action.BeginInvoke(Callback, "Invoking");
            action.Invoke();
            Console.ReadKey();
        }
        static async void Info()
        {
            Console.WriteLine("Invoked");
        }
        
    }
}
