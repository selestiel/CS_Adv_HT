using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L3_T3
{
    delegate int my_delegate();
    delegate void Anonim(my_delegate @delegate1, my_delegate @delegate2, my_delegate @delegate3, my_delegate @delegate4);
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            my_delegate md1 = new my_delegate(myClass.RndMtd);
            my_delegate md2 = new my_delegate(myClass.RndMtd);
            my_delegate md3 = new my_delegate(myClass.RndMtd);
            my_delegate md4 = new my_delegate(myClass.RndMtd);

            Anonim anonim = delegate (my_delegate a, my_delegate b, my_delegate c, my_delegate d)
            {
                Console.WriteLine(((a() + b() + c() + d()) / 4));
            };
            anonim.Invoke(md1,md2,md3,md4);
            Console.WriteLine();
            Console.ReadKey();

        }

    }
    class MyClass
    {
        public int RndMtd()
        {
            Random rnd;
            rnd = new Random();
            int x = rnd.Next(1, 100);
            return x;

        }
    }

}
