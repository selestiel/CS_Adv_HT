using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
    public class Orders
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Order_ID { get; set; }
        public string Order_Name { get; set; }
        public double Order_Price { get; set; }
        public DateTime Order_Date { get; set; }
        public Clients Clients { get; set; }
        public Admins Admins { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public void Create_Order(string name, Clients client, Admins admin, List<Products> products)
        {
            Order_ID++;
            Order_Name = name;
            double sum = 0;
            foreach (var item in products)
            {
                sum += item.Product_Price * item.Product_Buy;
                item.Product_Amount -= item.Product_Buy;
            }
            Order_Price = sum;
            Order_Date = DateTime.UtcNow;
            Clients = client;
            Admins = admin;
            Products = products;
        }
        public Orders()
        {
            this.Products = new List<Products>();
        }

    }
}
