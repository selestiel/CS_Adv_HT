namespace Adv_FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admins
    {

        [Key]
        public int Admin_ID { get; set; }

        public string Admin_First_Name { get; set; }

        public string Admin_Last_Name { get; set; }

        public string Admin_Email { get; set; }

        public string Admin_Phone_Number { get; set; }

        public double Admin_Money { get; set; }

        public DateTime Admin_Birth_Date { get; set; }

        public DateTime Admin_Registration_Date { get; set; }
        public Login Admin_Login { get; set; }
        public Password Admin_Password { get; set; }
        public virtual ICollection<Orders> Orders { get; }
        public virtual ICollection<Products> Products { get; }
        public virtual ICollection<Clients> Clients { get; }
        public void CreateAdmin(string Fname, string Lname, string Bdate, string phone, string email)
        {
            Admin_ID++;
            Admin_First_Name = Fname;
            Admin_Last_Name = Lname;
            Admin_Birth_Date = Convert.ToDateTime(Bdate);
            Admin_Phone_Number = phone;
            Admin_Email = email;
            Admin_Registration_Date = DateTime.UtcNow;
        }
        public string GetAdmin(Login login)
        {
            if (login.Admins_ID == Admin_ID)
            {
                return Admin_First_Name;
            }
            else
            {
                return "Error";
            }
        }
        public Admins()
        {
            Orders = new List<Orders>();
            Products = new List<Products>();
            Clients = new List<Clients>();
        }
    }
}
