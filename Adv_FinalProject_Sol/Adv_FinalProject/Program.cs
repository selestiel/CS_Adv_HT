using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Adv_FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MyModel>());

            using (MyModel adb = new MyModel())
            {

                Admins admins = new Admins();
                Login login = new Login();
                login.SetLogin("Admin123", "pass1234", admins);
                admins.CreateAdmin("Admintor", "RootAdmin", "02.03.2020", "+380555556399", "Admin@myapp.com",login);
                adb.Logins.Add(login);
                adb.Admins.Add(admins);
                Clients clients = new Clients();
                Login login1 = new Login();
                login1.SetLogin("user1234", "pass9876", clients);
                clients.CreateClient("Client01", "Jugo", "20.02.2012", "+380223256477", "Jugo@harvd.com",login);
                adb.Logins.Add(login1);
                adb.Clients.Add(clients);
                Products products = new Products();
                products.SetProduct("Engine", "Audi", 2500.00, 200);
                adb.Products.Add(products);
                Products products1 = new Products();
                products1.SetProduct("Box", "Demo", 150.00, 500);
                adb.Products.Add(products1);
                Products products2 = new Products();
                products2.SetProduct("Flames", "NOS", 500.00, 150);
                adb.Products.Add(products2);
                Orders orders = new Orders();
                List<Products> Prod = new List<Products>
                {
                    products,
                    products1,
                    products2
                };
                orders.CreateOrder("ForJugo", clients, Prod);
                adb.Orders.Add(orders);
                adb.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


        }
    }
}
