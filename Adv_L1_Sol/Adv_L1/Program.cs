using System;

namespace Adv_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<int> book1 = new Book<int>("Dears",2500);
            Book<string> book2 = new Book<string>("Reign","6000");
            book1.Show();
            book2.Show();

            Console.ReadKey();

        }

    }
    class Book<T>
    {
        private string name { get; set; }
        private T price { get; set; }
        public void Show()
        {
            Console.WriteLine(@" name: {0} price: {1}", name, price);
        }
        public Book(string n_name, T p_price)
        {
            name = n_name;
            price = p_price;
        }
    }
}
