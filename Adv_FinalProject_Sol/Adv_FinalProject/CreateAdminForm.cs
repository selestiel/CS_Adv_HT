using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class CreateAdminForm : Form
    {
        public CreateAdminForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Location = Properties.Settings.Default.MFLocation;
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = Properties.Settings.Default.TextFont;
            AdminBirthDate_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminEmail_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminLName_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminLogin_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminName_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminPassword_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminPhone_Lbl.Font = Properties.Settings.Default.TextFont;
            AdminBirthDate_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminEmail_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminLName_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminLogin_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminName_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminPassword_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminPhone_Lbl.ForeColor = Properties.Settings.Default.TextColor;
            AdminBDate_tbox.Font = Properties.Settings.Default.TextFont;
            AdminEmail_tbox.Font = Properties.Settings.Default.TextFont;
            AdminFName_tbox.Font = Properties.Settings.Default.TextFont;
            AdminLName_tbox.Font = Properties.Settings.Default.TextFont;
            AdminLogin_tbox.Font = Properties.Settings.Default.TextFont;
            AdminPassword_tbox.Font = Properties.Settings.Default.TextFont;
            AdminPhone_tbox.Font = Properties.Settings.Default.TextFont;
            AdminBDate_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AdminEmail_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AdminFName_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AdminLogin_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AdminLName_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AdminPassword_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AdminPhone_tbox.ForeColor = Properties.Settings.Default.TextColor;
            CreateAdmin_Btn.Font = Properties.Settings.Default.TextFont;
            CreateAdmin_Btn.ForeColor = Properties.Settings.Default.TextColor;

        }

        private void CreateAdmin_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
                string AFname = AdminFName_tbox.Text;
                string ALname = AdminLName_tbox.Text;
                string Aphone = AdminPhone_tbox.Text;
                string Aemail = AdminEmail_tbox.Text;
                string ABDate = AdminBDate_tbox.Text;
                string UcAlogin = AdminLogin_tbox.Text;
                string UcAPass = AdminPassword_tbox.Text;
                string Alogin = "";
                string Apass = "";
                if (ValidateLogin(UcAlogin, out UcAlogin) == true)
                {
                    Alogin = UcAlogin;
                    if (ValidatePassword(UcAPass, out UcAPass) == true)
                    {
                        Apass = UcAPass;
                        MessageBox.Show("Admin Created!");
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

                Admins NewAdmin = new Admins();
                Login login = new Login();
                login.SetLogin(Alogin, Apass,NewAdmin);
                NewAdmin.CreateAdmin(AFname, ALname, ABDate, Aphone, Aemail,login,login.Login_Name,login.Password_Name);
                adb.Logins.Add(login);
                adb.Admins.Add(NewAdmin);
                try
                {
                    adb.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
