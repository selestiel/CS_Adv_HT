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
        Orders orders = new Orders();
        Clients clients = new Clients();
        Products products = new Products();
        private void AddProduct_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
               // products.GetProduct(Products_Dgv.CurrentRow, Convert.ToInt32(AddProducAmount_tbox.Text));
                //adb.Products.Remove(products);
                //prod.Add(products);
                //adb.SaveChanges();
            }
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);
            // TODO: This line of code loads data into the '_FinalProjectDBContext_MyDbContextModelDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._FinalProjectDBContext_MyDbContextModelDataSet1.Products);

        }

        private void CheckOutOrder_Btn_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("D:/Test/MyFile", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine();
            writer.WriteLine("And thus the new Age has begun evolving entire world in some thing new, something chaotic!");
            writer.Close();
            stream.Close();
            
        }

        private void CreateOrder_Btn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.CreateOrder(OrderName_tbox.Text, clients.GetClient(Properties.Settings.Default.LoggedInName), prod);
        }

        private void ViewCheck_Btn_Click(object sender, EventArgs e)
        {
            if (File.Exists("MyFile") == true)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "D:/Test";
                fileDialog.FileName = "MyFile";
                fileDialog.OpenFile();
            }
        }
    }
}
