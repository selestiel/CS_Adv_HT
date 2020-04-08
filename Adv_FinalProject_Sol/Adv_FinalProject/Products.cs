namespace Adv_FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [Key]
        public int Product_ID { get; set; }

        public string Product_Name { get; set; }

        public string Product_Manufacturer { get; set; }

        public double Product_Price { get; set; }

        public int Product_Amount { get; set; }

        public virtual ICollection<Admins> Admins { get; }
        public virtual ICollection<Clients> Clients { get; }
        public virtual ICollection<Orders> Orders { get; }
        public void SetProduct(string name, string man, double price, int amount)
        {
            Product_ID++;
            Product_Name = name;
            Product_Manufacturer = man;
            Product_Price = price;
            Product_Amount = amount;
        }
        public void GetProduct(string name, string man, int amount)
        {
            if(Product_Name == name & Product_Manufacturer == man)
            {
                Product_Amount -= amount;
            }
        }
        public Products()
        {
            Admins = new List<Admins>();
            Clients = new List<Clients>();
            Orders = new List<Orders>();
        }

    }
}
