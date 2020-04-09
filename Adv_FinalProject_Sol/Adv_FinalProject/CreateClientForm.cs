using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class CreateClientForm : Form
    {
        public CreateClientForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Location = Properties.Settings.Default.MFLocation;
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = Properties.Settings.Default.TextFont;
            ClientBirthDate_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientEmail_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientLName_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientLogin_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientName_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientPassword_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientPhone_Lbl.Font = Properties.Settings.Default.TextFont;
            ClientBirthDate_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientEmail_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientLName_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientLogin_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientName_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientPassword_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientPhone_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            ClientBDate_tbox.Font= Properties.Settings.Default.TextFont;
            ClientEmail_tbox.Font = Properties.Settings.Default.TextFont;
            ClientFName_tbox.Font = Properties.Settings.Default.TextFont;
            ClientLName_tbox.Font = Properties.Settings.Default.TextFont;
            ClientLogin_tbox.Font = Properties.Settings.Default.TextFont;
            ClientPassword_tbox.Font = Properties.Settings.Default.TextFont;
            ClientPhone_tbox.Font = Properties.Settings.Default.TextFont;
            ClientBDate_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ClientEmail_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ClientFName_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ClientLogin_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ClientLName_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ClientPassword_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ClientPhone_tbox.ForeColor = Properties.Settings.Default.TextColor;
            CreateClient_Btn.Font = Properties.Settings.Default.TextFont;
            CreateClient_Btn.ForeColor = Properties.Settings.Default.TextColor;
        }
        private void CreateClient_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
                string CFname = ClientFName_tbox.Text;
                string CLname = ClientLName_tbox.Text;
                string Cphone = ClientPhone_tbox.Text;
                string Cemail = ClientEmail_tbox.Text;
                string CBDate = ClientBDate_tbox.Text;
                string UcClogin = ClientLogin_tbox.Text;
                string UcCPass = ClientPassword_tbox.Text;
                string Clogin = "";
                string Cpass = "";
                if (ValidateLogin(UcClogin, out UcClogin) == true)
                {
                    Clogin = UcClogin;
                    if (ValidatePassword(UcCPass, out UcCPass) == true)
                    {
                        Cpass = UcCPass;
                        MessageBox.Show("Client Created!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error wrong password input");
                    }
                }
                else
                {
                    MessageBox.Show("Error wrong login input");
                }

                Clients NewClient = new Clients();
                Login login = new Login();
                login.SetLogin(Clogin,Cpass, NewClient);
                NewClient.CreateClient(CFname, CLname, CBDate, Cphone, Cemail,login,login.Login_Name,login.Password_Name);
                adb.Logins.Add(login);
                adb.Clients.Add(NewClient);
                adb.SaveChanges();
            }
        }
        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one lower case letter.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be lesser than 8 or greater than 16 characters.";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one numeric value.";
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidateLogin(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasChar = new Regex(@"\w+");
            if (!hasChar.IsMatch(input))
            {
                ErrorMessage = "Login should contain at least one lower case letter.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Login should not be lesser than 5 or greater than 16 characters.";
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
