using System;
using System.Drawing;
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
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = new Font(Properties.Settings.Default.TextFont.Name, Convert.ToSingle(Properties.Settings.Default.TextFont.Size));

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
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Clients);
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Admins);

            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.clientsTableAdapter.GetData();
            this.adminsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Clients);
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Admins);

        }

        private void UpdTable_Btn_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.clientsTableAdapter.GetData();
            this.adminsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Clients);
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Admins);

        }
    }
}
