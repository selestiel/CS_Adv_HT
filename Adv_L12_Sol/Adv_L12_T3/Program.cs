using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Adv_L12_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = new Action(Operation_0);
            Task task = new Task(action);
            
            
            ThreadStart start = new ThreadStart(Operation_0);

            for (int i = 0; i < 200000; i++)
            {
                if (i == 5)
                {
                    task.RunSynchronously();
                    start.Invoke();
                    
                } 
                Console.WriteLine(new string(' ',5) + "Main in process");
            }
            Console.ReadKey();
            
        }
        static void Operation_0()
        {
            Action actionA = new Action(Operation_A);
            Task taskA = new Task(actionA);
            taskA.Start();
            Action actionB = new Action(Operation_B);
            Task taskB = new Task(actionB);
            taskB.Start();
            Action actionC = new Action(Operation_C);
            Task taskC = new Task(Operation_C);
            if (taskA.IsCompleted == true && taskB.IsCompleted == true)
            {
                taskC.Start();
            }
        }
        static void Operation_A()
        {
            for (int i = 0; i < 50; i++)
            {
            Thread.Sleep(200);
            Console.WriteLine(new string(' ',25) + "BAFOON");
            Thread.Sleep(100);
            Console.WriteLine(new string(' ',35) + "MAFFOON");
            }

        }
        static void Operation_B()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(150);
                Console.WriteLine(new string(' ',45) + "FUMAFUMAFUMA");
                Thread.Sleep(100);
                Console.WriteLine(new string(' ', 55) + "FUMMOFU");
                Thread.Sleep(150);
                Console.WriteLine(new string(' ', 65) + "SAYONARA");
            }
        }
        static void Operation_C()
        {
            Console.WriteLine("Operations Finished!");
        }
    }
}
