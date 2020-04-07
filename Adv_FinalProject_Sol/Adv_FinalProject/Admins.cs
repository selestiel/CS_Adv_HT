using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
    public class Admins
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Admin_ID { get; set; }
        public string Admin_First_Name { get; set; }
        public string Admin_Last_Name { get; set; }
        public string Admin_Email { get; set; }
        public string Admin_Phone_Number { get; set; }
        public double Admin_Money { get; set; }
        public DateTime Admin_Birth_Date { get; set; }
        public DateTime Admin_Registration_Date { get; set; }
        public LoginPass Admin_Login_Password { get; set; } 
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public void CreateAdmin(string fname, string lname, string email, string phone, DateTime BD)
        {
            Admin_ID++;
            Admin_First_Name = fname;
            Admin_Last_Name = lname;
            Admin_Email = email;
            Admin_Phone_Number = phone;
            Admin_Birth_Date = BD;
            Admin_Registration_Date = DateTime.UtcNow;
        }
        public void Admins_Set_LoginPass(LoginPass lp)
        {
            Admin_Login_Password = lp;
        }
        public void Admin_Add_Money(double money)
        {
            Admin_Money += money;
        }
        public Admins(string fname, string lname, string email, string phone, DateTime BD)
        {
            CreateAdmin(fname, lname, email, phone, BD);
            Orders = new List<Orders>();
            Products = new List<Products>();
        }
       
    }
}
