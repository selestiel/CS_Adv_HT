using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L4_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Lancer", "Mitsubishi", "Red", 1998);
            Car car2 = new Car("RX7", "Mazda", "Blue", 2010);
            Car car3 = new Car("GTR34", "Chevrolet", "Yellow", 2005);
            Car car4 = new Car("911", "Porshe", "White", 1990);
            Car car5 = new Car("Corolla", "Toyota", "Black", 1986);
            Car car6 = new Car("Corolla2", "Toyota", "Black", 1986);

            Client client1 = new Client("Joe","0-555-6987413","Lancer");
            Client client2 = new Client("John", "0-333-5446464","RX7");
            Client client3 = new Client("Josef", "3-255-0205546", "GTR34");
            Client client4 = new Client("Jory", "7-595-6879798", "911");
            Client client5 = new Client("Jared", "12-3114-97987987", "Corolla");

            List<Client> MyClient = new List<Client>();
            MyClient.Add(client1);
            MyClient.Add(client2);
            MyClient.Add(client3);
            MyClient.Add(client4);
            MyClient.Add(client5);
            List<Car> MyLict = new List<Car>();
            MyLict.Add(car1);
            MyLict.Add(car2);
            MyLict.Add(car3);
            MyLict.Add(car4);
            MyLict.Add(car5);
            MyLict.Add(car6);

            foreach (var item1 in MyClient)
            {
                foreach (var item2 in MyLict)
                {
                    if (item1.model == item2.model)
                    {
                        Console.WriteLine(@"Client: {0}  {1}  Car: {2} {3} {4} {5}",
                            item1.name, item1.phone, item2.model, item2.manuf, item2.color, item2.year);
                    }

                }
            }
            Console.ReadLine();
            




        }
    }
    class Car
    {
        public string model { get; set; }
        public string manuf { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public Car(string mod, string man, string col, int y)
        {
            model = mod;
            manuf = man;
            color = col;
            year = y;
        }
    }
    class Client
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string model { get; set; }
        public Client(string N, string P, string mdl)
        {
            name = N;
            phone = P;
            model = mdl;
        }
    }
}
