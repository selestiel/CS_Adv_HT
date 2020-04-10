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
            this.Font = Properties.Settings.Default.TextFont;
            Override_Btn.Enabled = false;
            Override_Btn.Visible = false;
            Login_Btn.ForeColor = Properties.Settings.Default.TextColor;
            Login_Btn.Font = Properties.Settings.Default.TextFont;
            Override_Btn.ForeColor = Properties.Settings.Default.TextColor;
            Override_Btn.Font = Properties.Settings.Default.TextFont;
            GoBack_Btn.ForeColor = Properties.Settings.Default.TextColor;
            GoBack_Btn.Font = Properties.Settings.Default.TextFont;
            Account_Info_lbl.Font = Properties.Settings.Default.TextFont;
            Account_Info_lbl.ForeColor = Properties.Settings.Default.TextColor;
            Login_lbl.Font = Properties.Settings.Default.TextFont;
            Login_lbl.ForeColor = Properties.Settings.Default.TextColor;
            Password_lbl.Font = Properties.Settings.Default.TextFont;
            Password_lbl.ForeColor = Properties.Settings.Default.TextColor;
            Admin_Checkbox.Font = Properties.Settings.Default.TextFont;
            Admin_Checkbox.ForeColor = Properties.Settings.Default.TextColor;
            Login_textbox.Font = Properties.Settings.Default.TextFont;
            Login_textbox.ForeColor = Properties.Settings.Default.TextColor;
            Password_textbox.Font = Properties.Settings.Default.TextFont;
            Password_textbox.ForeColor = Properties.Settings.Default.TextColor;
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
                    Properties.Settings.Default.Checkbox = true;
                    Properties.Settings.Default.Save();
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
                    Properties.Settings.Default.Checkbox = false;
                    Properties.Settings.Default.Save();
                    var cr = (from cli in lpdb.Clients where cli.Client_Login_Name == Login_textbox.Text select cli).FirstOrDefault();
                    if (cr != null)
                    {
                        if (cr.Client_Login_Pass_Name == Password_textbox.Text)
                        {
                            Close();
                            ClientForm Cform = new ClientForm();
                            Cform.Show();
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

        private void GoBack_Btn_Click(object sender, EventArgs e)
        {
            Close();
            MainForm main = new MainForm();
            main.Show();
        }
        //Button to skip login verification
        /* private void Override_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
        }
        */
    }
}
