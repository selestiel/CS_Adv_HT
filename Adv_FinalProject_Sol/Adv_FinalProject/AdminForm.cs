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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
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
            var hasNumber = new Regex(@"[0-9]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Login should contain at least one lower case letter.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Login should not be lesser than 8 or greater than 16 characters.";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Login should contain at least one numeric value.";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CreateClient_Btn_Click(object sender, EventArgs e)
        {
            CreateClientForm clform = new CreateClientForm();
            clform.Show();
        }

        private void CreateAdmin_Btn_Click(object sender, EventArgs e)
        {
            CreateAdminForm adminForm = new CreateAdminForm();
            adminForm.Show();
        }

        private void Override2_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }
    }
}
