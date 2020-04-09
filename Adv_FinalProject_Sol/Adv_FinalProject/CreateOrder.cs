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
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        List<Products> prod = new List<Products>();
        Orders orders = new Orders();
        Clients clients = new Clients();
        Products products = new Products();
        private void AddProduct_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel adb = new MyModel())
            {
                products.GetProduct(Convert.ToString(ProductsList_Lbox.SelectedItem), Convert.ToString(ProductsList_Lbox.SelectedItem), Convert.ToInt32(AddProducAmount_tbox.Text));
                adb.Products.Remove(products);
                prod.Add(products);
                adb.SaveChanges();
            }
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {

        }

        private void CheckOutOrder_Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
        }

        private void CreateOrder_Btn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.CreateOrder(OrderName_tbox.Text, clients.GetClient(Properties.Settings.Default.LoggedInName), prod);
        }
    }
}
