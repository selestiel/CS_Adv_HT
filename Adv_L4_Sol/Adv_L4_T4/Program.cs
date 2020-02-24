using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L4_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl1 = new Client(1, 2000, 10, 100);
            Client cl2 = new Client(2, 2001, 12, 150);
            Client cl3 = new Client(3, 2002, 7, 90);
            Client cl4 = new Client(4, 2003, 8, 850);
            Client cl5 = new Client(5, 2004, 9, 70);
            List<Client> list = new List<Client>();
            List<Client> list2 = new List<Client>();
            list.Add(cl1);
            list.Add(cl2);
            list.Add(cl3);
            list.Add(cl4);
            list.Add(cl5);
            foreach (var item in list)
            {
                if(item.hours < 100)
                {
                    list2.Add(item);
                }
            }
            list2.Last().Info();

            Console.ReadKey();
        }
    }
    class Client
    {
        int client_id { get; set; }
        int year { get; set; }
        int month { get; set; }
        public int hours { get; set; }
        public void Info()
        {
            Console.WriteLine("ID : {0} year: {1} month: {2} hours: {3}", client_id, year, month, hours);
        }
        public Client(int id, int y, int m, int h)
        {
            client_id = id;
            year = y;
            month = m;
            hours = h;
        }
    }
    
}
