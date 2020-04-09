using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Location = Properties.Settings.Default.MFLocation;
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = new Font(Properties.Settings.Default.TextFont.Name, Convert.ToSingle(Properties.Settings.Default.TextFont.Size));

        }
        private void MfRet()
        {
            Close();
            MainForm mf = new MainForm();
            mf.Show();
        }
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            using (var lpdb = new MyModel())
            {
                if (Admin_Checkbox.Checked == true)
                {
                    var ar = (from adm in lpdb.Admins where adm.Admin_Login_Name == Login_textbox.Text select adm).FirstOrDefault();
                    if (ar != null)
                    {
                        if (ar.Admin_Login_Pass_Name == Password_textbox.Text)
                        {
                            Close();
                            AdminForm Aform = new AdminForm();
                            Aform.Show();
                            Properties.Settings.Default.LoggedInName = ar.Admin_First_Name;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            MfRet();
                        }
                    }
                }
                else
                {
                    var cr = (from cli in lpdb.Clients where cli.Client_Login_Name == Login_textbox.Text select cli).FirstOrDefault();
                    if (cr != null)
                    {
                        if (cr.Client_Login_Pass_Name == Password_textbox.Text)
                        {
                            Close();
                            AdminForm Aform = new AdminForm();
                            Aform.Show();
                            Properties.Settings.Default.LoggedInName = cr.Client_First_Name;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            MfRet();
                        }
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
