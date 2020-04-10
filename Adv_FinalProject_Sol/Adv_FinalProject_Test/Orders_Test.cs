using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adv_FinalProject;
using System.Linq;

namespace Adv_FinalProject_Test
{
    [TestClass()]
    public class Orders_Test
    {
        [TestMethod()]
        public void CreateOrder_Product_Test()
        {
            Clients clients = new Clients();
            Login login = new Login();
            clients.CreateClient("User", "User", "01.01.2050", "6654464646", "jkighdfuihfd");
            login.SetLogin("userlogin1", "userpass1", clients);
            clients.SetClientLogin(login);
            Products Prod1 = new Products();
            Prod1.SetProduct("Flour", "KievMlin", 50.00, 3);
            Products Prod2 = new Products();
            Prod2.SetProduct("SmokedMeat", "Homemade", 350, 10);
            Products Prod3 = new Products();
            Prod3.SetProduct("Milk", "Yagotinske", 30.00, 50);
            Products Prod4 = new Products();
            Prod4.SetProduct("Potato", "Kherson", 20.00, 75);
            List<Products> LProd = new List<Products>()
            {
                Prod1, Prod2,Prod3,Prod4
            };
            Orders Order1 = new Orders();
            Order1.CreateOrder("Order1", clients, LProd);
            Assert.IsNotNull(clients);
            Assert.IsNotNull(login);
            Assert.AreEqual(login.Clients_ID, clients.Client_ID);
            Assert.IsNotNull(Prod1);
            Assert.IsNotNull(Prod2);
            Assert.IsNotNull(Prod3);
            Assert.IsNotNull(Prod4);
            Assert.IsNotNull(LProd);
            Assert.IsNotNull(Order1);
            Assert.AreEqual(Order1.Client_ID, clients.Client_ID);
            List<Products> LProd2 = new List<Products>()
            {
                Prod1.GetProduct(Prod1.Product_ID),
                Prod2.GetProduct(Prod2.Product_ID),
                Prod3.GetProduct(Prod3.Product_ID),
                Prod4.GetProduct(Prod4.Product_ID)

            };
            Assert.IsNotNull(LProd2);
            for (int i = 0; i < LProd.Count; i++)
            {
                for (int j = 0; j < LProd2.Count; j++)
                {
                    Assert.AreEqual(LProd.ElementAt(i).Product_ID, LProd2.ElementAt(j).Product_ID);
                }
            }
        }
    }
}
