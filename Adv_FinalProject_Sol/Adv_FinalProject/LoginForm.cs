using System;
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


            using (var lpdb = new MyDbContextModel())
            {
               var Pquery = from passwords in lpdb.LoginPasses
                             select passwords;
                foreach (var item in Pquery)
                {
                    if (Login.Equals(item.Login) && Pass.Equals(item.Password))
                    {
                        if (item.Admin_ID != 0) 
                        { 
                            Hide();
                            AdminForm Aform = new AdminForm();
                            Aform.Show();
                        }
                        else if (item.Client_ID != 0)
                        {
                            Hide();
                            ClientForm Cform = new ClientForm();
                            Cform.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error wrong Login or Password!");
                            MfRet();
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
    }
}
