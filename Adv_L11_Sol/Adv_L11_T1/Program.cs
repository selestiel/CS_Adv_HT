using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Adv_L11_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart thread = new ThreadStart(Range);
            Thread thread1 = new Thread(thread);
            thread1.Start();
            Console.WriteLine("ThreadStarted");
            
            Console.ReadKey();

        }
        public static void Range()
        {
            for (int i = 0; i < 3; i++) 
            {
                SomeClass some = new SomeClass(i, (string)("Some" + i), (double)(i * i));
                //some.Info();
                ThreadStart thread = new ThreadStart(Range);
                Thread thread1 = new Thread(thread);
                thread1.Start();
                


            }
        }

    }
    class SomeClass
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public double Cvar { get; set; }
        public void Info()
        {
            Console.WriteLine(@"ID: {0} NAME: {1} VAR: {2}", CID, CName, Cvar);
        }
        public SomeClass(int id, string name, double svar)
        {
            CID = id;
            CName = name;
            Cvar = svar;
            Info();
        }
    }
}
