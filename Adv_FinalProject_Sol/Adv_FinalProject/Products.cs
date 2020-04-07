using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
    public class Products
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Manufacturer { get; set; }
        public double Product_Price { get; set; }
        public int Product_Buy { get; set; }
        public int Product_Amount { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
        public virtual ICollection<Admins> Admins { get; set; }
        public void SetProduct(string name,string man, double price, int count)
        {
            Product_ID++; 
            Product_Name = name;
            Product_Manufacturer = man;
            Product_Price = price;
            Product_Amount += count;
            
        }
        public void GetProduct(string name, string man, double price, int count)
        {
            Product_Name = name;
            Product_Manufacturer = man;
            Product_Price = price;
            Product_Buy += count;

        }
        public Products()
        {
            this.Admins = new List<Admins>();
            this.Clients = new List<Clients>();
            this.Orders = new List<Orders>();
        }
    }
}
