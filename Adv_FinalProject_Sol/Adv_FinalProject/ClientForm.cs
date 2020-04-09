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
            this.Font = Properties.Settings.Default.TextFont;
            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
            Username_lbl.Font = Properties.Settings.Default.TextFont;
            Username_lbl.ForeColor = Properties.Settings.Default.TextColor;
            dataGridView1.ForeColor = Properties.Settings.Default.TextColor;
            dataGridView2.ForeColor = Properties.Settings.Default.TextColor;
            dataGridView1.Font = Properties.Settings.Default.TextFont;
            dataGridView2.Font = Properties.Settings.Default.TextFont;
            AddMoney_Btn.Font = Properties.Settings.Default.TextFont;
            AddOrder_Btn.Font = Properties.Settings.Default.TextFont;
            GoBack_Btn.Font = Properties.Settings.Default.TextFont;
            UpdTable_Btn.Font = Properties.Settings.Default.TextFont;
            AddMoney_tbox.Font = Properties.Settings.Default.TextFont;
            AddMoney_Btn.ForeColor = Properties.Settings.Default.TextColor;
            AddOrder_Btn.ForeColor = Properties.Settings.Default.TextColor;
            GoBack_Btn.ForeColor = Properties.Settings.Default.TextColor;
            UpdTable_Btn.ForeColor = Properties.Settings.Default.TextColor;
            AddMoney_tbox.ForeColor = Properties.Settings.Default.TextColor;
        }

        private void AddMoney_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel udb = new MyModel())
            {
                var ar = (from use in udb.Clients where use.Client_First_Name == Username_lbl.Text select use).FirstOrDefault();
                if (ar != null)
                {
                    ar.Client_Money += Convert.ToDouble(AddMoney_tbox.Text);
                }
                else
                {
                    MessageBox.Show("Error no Data");
                }
                
                udb.SaveChanges();

            }
        }
        private void AddOrder_Btn_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder();
            order.Show();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            using (MyModel udb = new MyModel())
            {
                var ar = (from use in udb.Clients where use.Client_First_Name == Username_lbl.Text select use).FirstOrDefault();
                if (ar != null)
                {
                    for (int i =0; i < dataGridView1.Rows.Count;i++)
                    {
                        if ( dataGridView1.Rows[i].Cells[4].Value.ToString() == ar.Client_ID.ToString())
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].Visible = true;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Visible = false;
                            dataGridView1.Rows[i].Selected = false;
                        }
                    }
                }
            }

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

        private void GoBack_Btn_Click(object sender, EventArgs e)
        {
            Close();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
