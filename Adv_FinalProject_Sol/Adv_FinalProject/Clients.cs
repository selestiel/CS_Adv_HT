using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
   public class Clients
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Client_ID { get; set; }
        public string Client_First_Name { get; set; }
        public string Client_Last_Name { get; set; }
        public string Client_Email { get; set; }
        public string Client_Phone_Number { get; set; }
        public double Client_Money { get; set; }
        public DateTime Client_Birth_Date { get; set; }
        public DateTime Client_Registration_Date { get; set; }
        public LoginPass Client_Login_Password { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        private void CreateClient(string fname, string lname, string email, string phone, DateTime BD)
        {
            Client_ID++;
            Client_First_Name = fname;
            Client_Last_Name = lname;
            Client_Email = email;
            Client_Phone_Number = phone;
            Client_Birth_Date = BD;
            Client_Registration_Date = DateTime.UtcNow;
        }
        public void Client_Add_Money(double money)
        {
            Client_Money += money;
        }
        public void SetClientPassword(LoginPass lp)
        {
            Client_Login_Password = lp;
        }
        public Clients(string fname, string lname, string email, string phone, DateTime BD)
        {
            CreateClient(fname, lname, email, phone, BD);
            Products = new List<Products>();
            Orders = new List<Orders>();
        }

    }
}
