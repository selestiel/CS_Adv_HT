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
            Database.SetInitializer(new DropCreateDatabaseAlways<MyDbContextModel>());

            using (MyDbContextModel adb = new MyDbContextModel())
            {

                Admins admins = new Admins("Admintor", "RootAdmin", "Admin@myapp.com", "+380555556399", Convert.ToDateTime("02.03.2020"));
                admins.Admins_Set_LoginPass(new LoginPass("Admin", "pass123456",null,admins));
                Clients clients = new Clients("Client01", "Jugo", "Jugo@harvd.com", "+380223256477", Convert.ToDateTime("20.02.2012"));
                clients.SetClientPassword(new LoginPass("jugonet", "pass987654", clients, null));
                Products products = new Products();
                products.SetProduct("Engine", "Audi", 2500.00, 200);
                products.SetProduct("Box", "Demo", 150.00, 500);
                products.SetProduct("Flames", "NOS", 500.00, 150);
                Orders orders = new Orders();
                List<Products> Prod = new List<Products>();
                Prod.Add(products);
                orders.Create_Order("ForJugo", clients, null, Prod);
                adb.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


        }
    }
}
