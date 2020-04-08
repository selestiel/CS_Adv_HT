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
        private void AddProduct_Btn_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            Products products = new Products();
            products.GetProduct(Convert.ToString(ProductsList_Lbox.SelectedItem), Convert.ToString(ProductsList_Lbox.SelectedItem), Convert.ToInt32(AddProducAmount_tbox.Text));
            prod.Add(products);
            orders.CreateOrder(OrderName_tbox.Text, clients.GetClient(Properties.Settings.Default.LoggedInName), prod);
        }

    }
}
