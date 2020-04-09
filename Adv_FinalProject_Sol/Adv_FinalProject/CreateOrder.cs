using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);
            Timer1.Enabled = true;
            Timer1.Start();
        }

        private void CheckOutOrder_Btn_Click(object sender, EventArgs e)
        {
            using (var mdb = new MyModel())
            {
                var ct = (from item in mdb.Clients where item.Client_First_Name == Username_lbl.Text select item).FirstOrDefault();
                G_Order.Client_ID = ct.Client_ID;
                Directory.CreateDirectory("D:/Test");
                FileStream stream = new FileStream("D:/Test/MyFile.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine("Order ID: " + G_Order.Order_ID);
                writer.WriteLine("Order Name: " + G_Order.Order_Name);
                writer.WriteLine("Order Date: " + G_Order.Order_Date);
                writer.WriteLine("Order Total Price: " + G_Order.Order_Price);
                writer.WriteLine("Client ID: " + G_Order.Client_ID);
                foreach (var item in G_Order.Products)
                {
                    writer.Write(" Product Made by: " + item.Product_Manufacturer + "\t"
                        + "Product Name: " + item.Product_Name + "\t"
                        + "Product Amount: " + item.Product_Amount + "\t"
                        + "Product Price: " + item.Product_Price);
                }
                writer.WriteLine();
                writer.Close();
                stream.Close();
                prod = null;
                G_Order = null;
            }
            
        }

        private void CreateOrder_Btn_Click(object sender, EventArgs e)
        {
            using (var mdb = new MyModel())
            {
                var ct = (from item in mdb.Clients where item.Client_First_Name == Username_lbl.Text select item).FirstOrDefault();
                Orders orders = new Orders();
                orders.CreateOrder(OrderName_tbox.Text, ct, prod);
                G_Order = orders;
            }
        }

        private void ViewCheck_Btn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = @"D:/Test/MyFile.txt";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:/";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var process = new Process();
                    process.StartInfo = new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        FileName = filePath
                    };

                    process.Start();
                    process.WaitForExit();

                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.productsTableAdapter.GetData();
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet3.Products);

        }
    }
}
