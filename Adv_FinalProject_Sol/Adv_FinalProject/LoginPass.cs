using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
    public class LoginPass
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Login_Pass_ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Client_ID { get; set; }
        public int Admin_ID { get; set; }

        public void SetLoginPass(string login, string pass, Clients clients, Admins admin)
        {
            if (clients != null && admin == null)
            {
                Client_ID = clients.Client_ID;
            }
            else if (clients==null && admin!= null)
            {
                Admin_ID = admin.Admin_ID;
            }
            else
            {
                Client_ID = 0;
                Admin_ID = 0;
            }
            Login_Pass_ID++;
            Login = login;
            Password = pass;
        }
        public LoginPass(string login,string pass, Clients clients, Admins admins)
        {
            SetLoginPass(login, pass, clients,admins);
        }
        public LoginPass()
        {
            Login_Pass_ID = 0;
            Login = "zero";
            Password = "zero";
            Client_ID = 0;
            Admin_ID = 1;
        }
    }
}
