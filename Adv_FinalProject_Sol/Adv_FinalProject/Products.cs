namespace Adv_FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int Product_ID { get; set; }

        public string Product_Name { get; set; }

        public string Product_Manufacturer { get; set; }

        public double Product_Price { get; set; }

        public int Product_Amount { get; set; }
        public int Product_AmountToSell { get; set; }

        public Admins  Admins{ get; set; }
        public  Clients Clients { get; set; }
        public  Orders Orders { get; set; }
        public void SetProduct(string name, string man, double price, int amount)
        {
            ++Product_ID;
            Product_Name = name;
            Product_Manufacturer = man;
            Product_Price = price;
            Product_Amount = amount;
        }
        public Products GetProduct(int index)
        {
            if(Product_ID == index)
            {
                return this;
            }
            else
            {
                return null;
            }
        }
        public Products()
        {
        }

    }
}
