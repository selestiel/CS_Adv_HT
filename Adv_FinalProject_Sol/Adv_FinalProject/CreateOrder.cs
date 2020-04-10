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
            this.Font = Properties.Settings.Default.TextFont;
            Admin_Checkbox.Checked = Properties.Settings.Default.Checkbox;
            Properties.Settings.Default.Upgrade();
            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
            Username_lbl.Font = Properties.Settings.Default.TextFont;
            Username_lbl.ForeColor = Properties.Settings.Default.TextColor;
            OrderName_lbl.Font = Properties.Settings.Default.TextFont;
            OrderName_lbl.ForeColor = Properties.Settings.Default.TextColor;
            ProdList_lbl.Font = Properties.Settings.Default.TextFont;
            ProdList_lbl.ForeColor = Properties.Settings.Default.TextColor;
            Products_Dgv.Font = Properties.Settings.Default.TextFont;
            Products_Dgv.ForeColor = Properties.Settings.Default.TextColor;
            AddProducAmount_tbox.Font = Properties.Settings.Default.TextFont;
            AddProducAmount_tbox.ForeColor = Properties.Settings.Default.TextColor;
            OrderName_tbox.Font = Properties.Settings.Default.TextFont;
            OrderName_tbox.ForeColor = Properties.Settings.Default.TextColor;
            AddProduct_Btn.Font = Properties.Settings.Default.TextFont;
            AddProduct_Btn.ForeColor = Properties.Settings.Default.TextColor;
            CheckOutOrder_Btn.Font = Properties.Settings.Default.TextFont;
            CheckOutOrder_Btn.ForeColor = Properties.Settings.Default.TextColor;
            CreateOrder_Btn.Font = Properties.Settings.Default.TextFont;
            CreateOrder_Btn.ForeColor = Properties.Settings.Default.TextColor;
            GoBack_Btn.Font = Properties.Settings.Default.TextFont;
            GoBack_Btn.ForeColor = Properties.Settings.Default.TextColor;
            ViewCheck_Btn.Font = Properties.Settings.Default.TextFont;
            ViewCheck_Btn.ForeColor = Properties.Settings.Default.TextColor;
            NextOrder_Btn.Font = Properties.Settings.Default.TextFont;
            NextOrder_Btn.ForeColor = Properties.Settings.Default.TextColor;
        }

        List<Products> G_Prod = new List<Products>();
        Orders G_Order = new Orders();

        private void AddProduct_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel odb = new MyModel())
            {
                Products_Dgv.CurrentCell.Selected = true;
                var ord = (from item in odb.Products where item.Product_ID == Products_Dgv.CurrentCell.RowIndex select item).FirstOrDefault();

                if (ord != null) 
                {
                    ord.Product_AmountToSell = Convert.ToInt32(AddProducAmount_tbox.Text);
                    ord.Product_Amount -= Convert.ToInt32(AddProducAmount_tbox.Text);
                    G_Prod.Add(ord);
                    odb.SaveChanges();
                }
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
                if (Admin_Checkbox.Checked == false)
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
                    foreach (Products item in G_Order.Products)
                    {
                        writer.WriteLine(@" Product Made by: " + item.Product_Manufacturer + " \t"
                            + " Product Name: " + item.Product_Name + " \t"
                            + " Product Amount: " + item.Product_AmountToSell + " \t"
                            + " Product Price: " + item.Product_Price);
                    }
                    var ppl = (from izem in mdb.Clients where izem.Client_First_Name == Username_lbl.Text select izem).FirstOrDefault();
                    ppl.Client_Money -= G_Order.Order_Price;
                    G_Order.Order_Price = 0;
                    mdb.SaveChanges();
                    writer.Close();
                    stream.Close();
                }
                else
                {
                    var at = (from item in mdb.Admins where item.Admin_First_Name == Username_lbl.Text select item).FirstOrDefault();
                    G_Order.Admin_ID = at.Admin_ID;
                    Directory.CreateDirectory("D:/Test");
                    FileStream stream = new FileStream("D:/Test/MyFile.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine("Order ID: " + G_Order.Order_ID);
                    writer.WriteLine("Order Name: " + G_Order.Order_Name);
                    writer.WriteLine("Order Date: " + G_Order.Order_Date);
                    writer.WriteLine("Order Total Price: " + G_Order.Order_Price);
                    writer.WriteLine("Client ID: " + G_Order.Admin_ID);
                    foreach (Products item in G_Order.Products)
                    {
                        writer.Write(" Product Made by: " + item.Product_Manufacturer + " \t"
                            + " Product Name: " + item.Product_Name + " \t"
                            + " Product Amount: " + item.Product_AmountToSell + " \t"
                            + " Product Price: " + item.Product_Price);
                    }
                    writer.WriteLine();
                    var ppl = (from izem in mdb.Admins where izem.Admin_First_Name == Username_lbl.Text select izem).FirstOrDefault();
                    ppl.Admin_Money -= G_Order.Order_Price;
                    G_Order.Order_Price = 0;
                    mdb.SaveChanges();
                    writer.Close();
                    stream.Close();
                }
            }
            
        }

        private void CreateOrder_Btn_Click(object sender, EventArgs e)
        {

            using (var mdb = new MyModel())
            {
                
                if (Admin_Checkbox.Checked == true)
                {
                    var at = (from item in mdb.Admins where item.Admin_First_Name == Username_lbl.Text select item).FirstOrDefault();
                    Orders orders1 = new Orders();
                    orders1.CreateOrder(OrderName_tbox.Text, at, G_Prod);
                    G_Order = orders1;
                    mdb.Orders.Add(G_Order);
                    mdb.SaveChanges();
                }
                else
                {
                    var ct = (from item in mdb.Clients where item.Client_First_Name == Username_lbl.Text select item).FirstOrDefault();
                    Orders orders2 = new Orders();
                    orders2.CreateOrder(OrderName_tbox.Text, ct, G_Prod);
                    G_Order = orders2;
                    mdb.Orders.Add(G_Order);
                    mdb.SaveChanges();
                }

                MessageBox.Show(G_Order.Products.Count.ToString());

            }
        }

        private void ViewCheck_Btn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:/Test/";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            UseShellExecute = true,
                            FileName = filePath
                        }
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

        private void GoBack_Btn_Click(object sender, EventArgs e)
        {
            Close();
            MainForm main = new MainForm();
            main.Show();
        }

        private void NextOrder_Btn_Click(object sender, EventArgs e)
        {
            G_Order = null;
            G_Prod = null;
        }
    }
}
