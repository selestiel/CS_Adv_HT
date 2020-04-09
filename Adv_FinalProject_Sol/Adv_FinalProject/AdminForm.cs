using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Width = Properties.Settings.Default.MFWidth;
            this.Height = Properties.Settings.Default.MFHeight;
            this.Location = Properties.Settings.Default.MFLocation;
            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
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

        private void AddMoney_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
                Admins admins = new Admins();
                if (admins.Admin_First_Name == Properties.Settings.Default.LoggedInName)
                {
                    admins.Admin_Money += Convert.ToDouble(AddMoney_tbox.Text);
                    adb.Admins.Add(admins);
                }
                else
                {
                    MessageBox.Show("Error no Data");
                }

                adb.SaveChanges();

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Clients);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet2.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Admins);

            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.clientsTableAdapter.GetData();
            this.adminsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Clients);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet2.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Admins);

        }

        private void UpdTable_Btn_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.clientsTableAdapter.GetData();
            this.adminsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Clients);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet2.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Admins);

        }
    }
}
