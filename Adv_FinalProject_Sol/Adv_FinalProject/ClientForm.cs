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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Location = Properties.Settings.Default.MFLocation;
            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
        }

        private void AddMoney_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
                Clients clients = new Clients();
                if (clients.Client_First_Name == Properties.Settings.Default.LoggedInName)
                {
                    clients.Client_Money += Convert.ToDouble(AddMoney_tbox.Text);
                    adb.Clients.Add(clients);
                }
                else
                {
                    MessageBox.Show("Error no Data");
                }
                
                adb.SaveChanges();

            }
        }
        private void AddOrder_Btn_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder();
            order.Show();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);

        }

        private void UpdTable_Btn_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet.Orders);

        }
    }
}
