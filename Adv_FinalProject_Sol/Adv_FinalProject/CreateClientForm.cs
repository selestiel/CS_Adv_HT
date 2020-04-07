﻿using System;
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
        }


        private void CreateClient_Btn_Click(object sender, EventArgs e)
        {
            string CFname = ClientFName_tbox.Text;
            string CLname = ClientLName_tbox.Text;
            string Cphone = ClientPhone_tbox.Text;
            string Cemail = ClientEmail_tbox.Text;
            DateTime CBDate = Convert.ToDateTime(ClientBDate_tbox.Text);
            string UcClogin = ClientLogin_tbox.Text;
            string UcCPass = ClientPassword_tbox.Text;
            string Clogin = "";
            string Cpass = "";
            if(ValidateLogin(UcClogin,out UcClogin) == true)
            {
                Clogin = UcClogin;
                if(ValidatePassword(UcCPass,out UcCPass) == true)
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

            Clients NewClient = new Clients(CFname, CLname, Cemail, Cphone, CBDate);
            NewClient.SetClientPassword(new LoginPass(Clogin,Cpass,NewClient,null));
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
