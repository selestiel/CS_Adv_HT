namespace Adv_FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {

        public int Client_ID { get; set; }

        public string Client_First_Name { get; set; }

        public string Client_Last_Name { get; set; }

        public string Client_Email { get; set; }

        public string Client_Phone_Number { get; set; }

        public double Client_Money { get; set; }

        public DateTime Client_Birth_Date { get; set; }

        public DateTime Client_Registration_Date { get; set; }

        public Login Client_Login { get; set; }
        public Password Client_Password { get; set; }
        public virtual ICollection<Orders> Orders { get; }
        public virtual ICollection<Products> Products { get; }
        public void CreateClient(string Fname, string Lname, string Bdate, string phone, string email)
        {
            Client_ID++;
            Client_First_Name = Fname;
            Client_Last_Name = Lname;
            Client_Birth_Date = Convert.ToDateTime(Bdate);
            Client_Phone_Number = phone;
            Client_Email = email;
            Client_Registration_Date = DateTime.UtcNow;
        }
        public string GetClient(Login login)
        {
            if(Client_ID == login.Clients_ID)
            {
                return Client_First_Name;
            }
            else
            {
                return "Error";
            }
        }
        public Clients GetClient(string name)
        {
            if (Client_First_Name == name)
            {
                return this;
            }
            else
            {
                return null;
            }

        }
        public Clients()
        {
            Orders = new List<Orders>();
            Products = new List<Products>();
        }
    }
}
