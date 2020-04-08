namespace Adv_FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {

        [Key]
        public int Order_ID { get; set; }

        public string Order_Name { get; set; }

        public double Order_Price { get; set; }

        public DateTime Order_Date { get; set; }

        public int? Admin_ID { get; set; }

        public int? Client_ID { get; set; }

        public virtual ICollection<Admins> Admins { get; }

        public virtual ICollection<Clients> Clients { get; }

        public virtual ICollection<Products> Products { get; }
        public void CreateOrder(string name, Admins admins,List<Products> products)
        {
            Order_ID++;
            Order_Name = name;
            Admin_ID = admins.Admin_ID;
            foreach  (Products item in products)
            {
                Order_Price += item.Product_Price * item.Product_Amount;
            }
        }
        public void CreateOrder(string name, Clients clients, List<Products> products)
        {
            Order_ID++;
            Order_Name = name;
            Client_ID = clients.Client_ID;
            foreach (Products item in products)
            {
                Order_Price += item.Product_Price * item.Product_Amount;
            }
        }
        public Orders()
        {
            Admins = new List<Admins>();
            Clients = new List<Clients>();
            Products = new List<Products>();
        }
    }
}
