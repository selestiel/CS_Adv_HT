using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class CreateAdminForm : Form
    {
        public CreateAdminForm()
        {
            InitializeComponent();
        }

        private void CreateAdmin_Btn_Click(object sender, EventArgs e)
        {

            string AFname = AdminFName_tbox.Text;
            string ALname = AdminLName_tbox.Text;
            string Aphone = AdminPhone_tbox.Text;
            string Aemail = AdminEmail_tbox.Text;
            DateTime ABDate = Convert.ToDateTime(AdminBDate_tbox.Text);
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

            Admins NewAdmin = new Admins(AFname, ALname, Aemail, Aphone, ABDate);
            NewAdmin.Admins_Set_LoginPass(new LoginPass(Alogin, Apass,null,NewAdmin));
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
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one lower case letter.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one upper case letter.";
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

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one special case character.";
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
