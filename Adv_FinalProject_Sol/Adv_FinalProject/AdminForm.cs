using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Font = Properties.Settings.Default.TextFont;

            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
            Username_lbl.ForeColor = Properties.Settings.Default.TextColor;
            Username_lbl.Font = Properties.Settings.Default.TextFont;
            Admins_DataGridV.Font = Properties.Settings.Default.TextFont;
            Admins_DataGridV.ForeColor = Properties.Settings.Default.TextColor;
            Clients_DataGridV.Font = Properties.Settings.Default.TextFont;
            Clients_DataGridV.ForeColor = Properties.Settings.Default.TextColor;
            Orders_DataGridV.Font = Properties.Settings.Default.TextFont;
            Orders_DataGridV.ForeColor = Properties.Settings.Default.TextColor;
            Products_DataGrid_V.Font = Properties.Settings.Default.TextFont;
            Products_DataGrid_V.ForeColor = Properties.Settings.Default.TextColor;
            AddMoney_tbox.Font = Properties.Settings.Default.TextFont;
            AddMoney_tbox.ForeColor = Properties.Settings.Default.TextColor;
            UpdTable_Btn.Font = Properties.Settings.Default.TextFont;
            UpdTable_Btn.ForeColor = Properties.Settings.Default.TextColor;
            Override2_Btn.Font = Properties.Settings.Default.TextFont;
            Override2_Btn.ForeColor = Properties.Settings.Default.TextColor;
            GoBack_Btn.Font = Properties.Settings.Default.TextFont;
            GoBack_Btn.ForeColor = Properties.Settings.Default.TextColor;
            CreateClient_Btn.Font = Properties.Settings.Default.TextFont;
            CreateClient_Btn.ForeColor = Properties.Settings.Default.TextColor;
            CreateAdmin_Btn.Font = Properties.Settings.Default.TextFont;
            CreateAdmin_Btn.ForeColor = Properties.Settings.Default.TextColor;
            AddMoney_Btn.Font = Properties.Settings.Default.TextFont;
            AddMoney_Btn.ForeColor = Properties.Settings.Default.TextColor;
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
            using (MyModel db = new MyModel())
            {
                var ar = (from user in db.Admins where user.Admin_First_Name == Username_lbl.Text select user).FirstOrDefault();
                if (ar != null)
                {
                    ar.Admin_Money += Convert.ToDouble(AddMoney_tbox.Text);
                }
                else
                {
                    MessageBox.Show("Error no Data");
                }

                db.SaveChanges();

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Orders);
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Clients);
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Admins);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.clientsTableAdapter.GetData();
            this.adminsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Orders);
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Clients);
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Admins);

        }

        private void UpdTable_Btn_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.clientsTableAdapter.GetData();
            this.adminsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Orders);
            this.clientsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Clients);
            this.adminsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Admins);

        }

        private void GoBack_Btn_Click(object sender, EventArgs e)
        {
            Close();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
