using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L2_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<T> enumerable = new MyList<T>();
            IEnumerator<T> enumerator = enumerable.GetEnumerator();
            MyList<int> ML = new MyList<int>();
            int i = 0;
            while (i<20)
            {
                ML.Add(i++);
            }
            foreach (var item in ML)
	        {
                Console.Write("\t" + item);
	        }
            Console.WriteLine();
            MyList<string> MLS = new MyList<string>();
            int j =0;
            while(j<20)
            {
                MLS.Add("strN" + j);
            }
            foreach (var item in MLS)
	        {
                Console.Write("\t" + item);
	        }
            Console.WriteLine();
            


            Console.WriteLine();
            Console.ReadKey();
        }
    }
    interface IMyList<T>
    {
        void Add(T arg);
        T this[int index] { get; }
        int count { get; }
        void Clear();
        bool Contains(T item);

    }
    class MyList<T> : IMyList<T>
    {
        private T[] array;

        public int count { get; }
        
        public T this[int index] 
        { 
            get
            {
                return value;
            }
        }
        public void Add(T arg)
        {
        }
        public void Clear()
        {  
        }
        public bool Contains(T item)
        {
        }
    }
    }