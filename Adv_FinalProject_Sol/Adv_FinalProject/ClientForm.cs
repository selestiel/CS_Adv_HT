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
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = new Font(Properties.Settings.Default.TextFont.Name, Convert.ToSingle(Properties.Settings.Default.TextFont.Size));

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
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Orders);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Orders);

        }

        private void UpdTable_Btn_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.ordersTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            this.ordersTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet2.Orders);

        }
    }
}
