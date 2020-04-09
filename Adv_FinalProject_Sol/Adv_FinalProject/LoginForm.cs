﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void MfRet()
        {
            Close();
            MainForm mf = new MainForm();
            mf.Show();
        }
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string Login = Login_textbox.Text;
            string Pass = Password_textbox.Text;


            using (var lpdb = new MyModel())
            {
                foreach (Login logc in lpdb.Logins)
                {
                    if (logc.Login_Name.Equals(Login))
                    {
                        foreach (Password pasc in lpdb.Passwords)
                        {
                            if (pasc.Password_Name.Equals(Pass) & logc.Admins_ID == pasc.Admins_ID)
                            {
                                if (logc.Admins_ID != 0)
                                {
                                    Hide();
                                    AdminForm Aform = new AdminForm();
                                    Aform.Show();
                                    Admins admins = new Admins();
                                    Properties.Settings.Default.LoggedInName = admins.GetAdmin(logc);
                                }
                                else
                                {
                                    MessageBox.Show("Error wrong Login or Password!");
                                    MfRet();
                                }
                            }
                            else if (pasc.Password_Name.Equals(Pass) & logc.Clients_ID == pasc.Clients_ID)
                            {
                                Hide();
                                ClientForm Cform = new ClientForm();
                                Cform.Show();
                                Clients clients = new Clients();
                                Properties.Settings.Default.LoggedInName = clients.GetClient(logc);
                            }
                            else
                            {
                                MessageBox.Show("Error wrong Login or Password!");
                                MfRet();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error wrong Login or Password!");
                        MfRet();
                    }
                }
            }
        }
        private void Override_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
        }
    }
}