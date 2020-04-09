using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_FinalProject
{
    public class Password
    {
       
        public int Password_ID { get; set; }
        public string Password_Name { get; set; }
        public int Admins_ID { get; set; }
        public int Clients_ID { get; set; }

        public void SetPassword(string name, Admins admin)
        {
            Password_ID++;
            Password_Name = name;
            Admins_ID = admin.Admin_ID;
        }
        public void SetPassword(string name, Clients client)
        {
            Password_ID++;
            Password_Name = name;
            Clients_ID = client.Client_ID;
        }
        public string GetPassword(Admins admins)
        {
            if (Admins_ID == admins.Admin_ID)
            {
                return Password_Name;
            }
            else
            {
                return "Error";
            }
        }
        public string GetPassword(Clients clients)
        {
            if (Admins_ID == clients.Client_ID)
            {
                return Password_Name;
            }
            else
            {
                return "Error";
            }
        }
    }
}
