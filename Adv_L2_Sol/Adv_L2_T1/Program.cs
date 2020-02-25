using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Adv_L2_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ML = new MyList<int>(20,0);
            for (int i = 0; i < 20; i++)
            {
                ML[i] = i;

            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(" " + ML[i]);
            }

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
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Add(T arg)
        {
            array.Append(arg);
        }
        public void Clear()
        {
            Array.Empty<T>();
        }
        public bool Contains(T item)
        {
            dynamic itemx = 0;

            foreach (dynamic itemc in array)
            {
                if (itemc.Equals(item))
                {
                    itemx = itemc;
                }
                else
                {
                    itemx = 0;
                }
            }
            if (!itemx.Equals(item))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public MyList(int len, T nm)
        {
            array = new T[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = nm;
            }
        }

    }
}