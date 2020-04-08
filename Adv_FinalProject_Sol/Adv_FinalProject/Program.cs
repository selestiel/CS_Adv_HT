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
            //Database.SetInitializer(new DropCreateDatabaseAlways<MyDbContextModel>());

            using (MyModel adb = new MyModel())
            {

                Admins admins = new Admins();
                admins.CreateAdmin("Admintor", "RootAdmin", "02.03.2020", "+380555556399", "Admin@myapp.com");
                Login login = new Login();
                login.SetLogin("Admin123", admins);
                Password password = new Password();
                password.SetPassword("pass1234", admins);

                Clients clients = new Clients();
                clients.CreateClient("Client01", "Jugo", "20.02.2012", "+380223256477", "Jugo@harvd.com");
                login.SetLogin("user1234", clients);
                password.SetPassword("pass9876", clients);
                Products products = new Products();
                products.SetProduct("Engine", "Audi", 2500.00, 200);
                products.SetProduct("Box", "Demo", 150.00, 500);
                products.SetProduct("Flames", "NOS", 500.00, 150);
                Orders orders = new Orders();
                List<Products> Prod = new List<Products>();
                Prod.Add(products);
                orders.CreateOrder("ForJugo", clients, Prod);
                adb.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


        }
    }
}
