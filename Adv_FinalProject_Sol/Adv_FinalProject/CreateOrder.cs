using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adv_FinalProject
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Location = Properties.Settings.Default.MFLocation;
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = new Font(Properties.Settings.Default.TextFont.Name, Convert.ToSingle(Properties.Settings.Default.TextFont.Size));

            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
        }

        List<Products> prod = new List<Products>();
        Orders G_Order = new Orders();
        readonly Clients clients = new Clients();
        private void AddProduct_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
                Products product1 = new Products();
                product1.GetProduct(Products_Dgv.CurrentCell.RowIndex);
                product1.Product_Amount -= Convert.ToInt32(AddProducAmount_tbox.Text);
                Products product2 = new Products();
                product2 = product1;
                product2.Product_Amount = Convert.ToInt32(AddProducAmount_tbox.Text);
                prod.Add(product2);
                adb.SaveChanges();
            }
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);

        }

        private void CheckOutOrder_Btn_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("D:/Test/MyFile.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(G_Order.Order_ID);
            writer.WriteLine(G_Order.Order_Name);
            writer.WriteLine(G_Order.Order_Date);
            writer.WriteLine(G_Order.Order_Price);
            writer.WriteLine(G_Order.Client_ID);
            foreach (var item in G_Order.Products)
            {
                writer.Write(item.Product_Manufacturer + "\t"
                    + item.Product_Name + "\t" + item.Product_Amount + "\t"
                    + item.Product_Price);
            }
            writer.WriteLine();
            writer.Close();
            stream.Close();
            prod = null;
            G_Order = null;
            
        }

        private void CreateOrder_Btn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.CreateOrder(OrderName_tbox.Text, clients.GetClient(Properties.Settings.Default.LoggedInName), prod);
            G_Order = orders;
        }

        private void ViewCheck_Btn_Click(object sender, EventArgs e)
        {
            if (File.Exists("MyFile.txt") == true)
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    InitialDirectory = "D:/Test",
                    FileName = "MyFile.txt"
                };
                fileDialog.OpenFile();
            }
        }
    }
}
