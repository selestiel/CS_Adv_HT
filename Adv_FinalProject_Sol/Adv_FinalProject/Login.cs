using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
    public class Login
    {
        [Key]
        public int Login_ID { get; set; }
        public string Login_Name { get; set; }
        public int? Admins_ID { get; set; }
        public int? Clients_ID { get; set; }
        public void SetLogin(string name,Admins admin)
        {
            Login_ID++;
            Login_Name = name;
            Admins_ID = admin.Admin_ID;
        }
        public void SetLogin(string name, Clients client)
        {
            Login_ID++;
            Login_Name = name;
            Clients_ID = client.Client_ID;
        }
        public string GetLogin(Admins admins)
        {
            if(Admins_ID == admins.Admin_ID)
            {
                return Login_Name;
            }
            else
            {
                return "Error";
            }
        }
        public string GetLogin(Clients clients)
        {
            if (Admins_ID == clients.Client_ID)
            {
                return Login_Name;
            }
            else
            {
                return "Error";
            }
        }
    }
}
