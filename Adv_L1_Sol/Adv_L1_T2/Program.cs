using System;
using System.Collections.Generic;


namespace Adv_L1_T2
{
    class Program
    {
        static void Main(string[] args)
        {

            
                MyClass<int>.FabricMethod();
                MyClass<char>.FabricMethod();
                MyClass<string>.FabricMethod();
                MyClass<double>.FabricMethod();

            
            Console.ReadKey();
        }
    }
    class MyClass<T>
    {
        
        public static MyClass<T> FabricMethod()
        {
            MyClass<T> myClass = new MyClass<T>();
            return myClass;
        }

    }


}
  
