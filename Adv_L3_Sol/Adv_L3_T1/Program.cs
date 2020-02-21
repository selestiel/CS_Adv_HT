using System;
namespace Adv_L3_T1
{
    public delegate int mydelegate(int arg1, int arg2, int arg3);
    delegate void Anonim(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MyClass MC = new MyClass();
            mydelegate md = new mydelegate(MC.Method);
            Console.WriteLine(  md.Invoke(56, 57, 58));
            Anonim anonim = delegate (int arg1, int arg2, int arg3)
            {
                Console.WriteLine(((arg1 + arg2 + arg3) / 3));
            };
            anonim.Invoke(25, 35, 45);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.ReadKey();
        }

    }
    class MyClass
    {
        public int Method(int arg1, int arg2, int arg3)
    {
        return (arg1*arg2*arg3);
    }
    
    }
}
