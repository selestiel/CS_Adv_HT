namespace Adv_FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        public int Order_ID { get; set; }

        public string Order_Name { get; set; }

        public double Order_Price { get; set; }

        public DateTime Order_Date { get; set; }

        public int Admin_ID { get; set; }

        public int Client_ID { get; set; }

        public virtual ICollection<Admins> Admins { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
        public virtual ICollection<Products> Products { get; set; }

        public void CreateOrder(string name, Admins admins, List<Products> products)
        {
            Order_ID++;
            Order_Name = name;
            Admin_ID = admins.Admin_ID;
            Order_Date = DateTime.UtcNow;
            this.Products = products;
            foreach  (Products item in products)
            {
                Order_Price += item.Product_Price * item.Product_AmountToSell;
            }

        }
        public void CreateOrder(string name, Clients clients, List<Products> products)
        {
            Order_ID++;
            Order_Name = name;
            Client_ID = clients.Client_ID;
            Order_Date = DateTime.UtcNow;
            Products = products;
            foreach (Products item in products)
            {
                Order_Price += item.Product_Price * item.Product_AmountToSell;
            }
        }
        public Orders()
        {
            Admins = new List<Admins>();
            Clients = new List<Clients>();
            Products = this.Products;
        }
    }
}
