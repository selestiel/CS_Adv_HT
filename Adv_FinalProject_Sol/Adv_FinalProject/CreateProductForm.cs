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
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Location = Properties.Settings.Default.MFLocation;
            this.ForeColor = Properties.Settings.Default.TextColor;
            this.Font = Properties.Settings.Default.TextFont;
            ProductAmount_lbl.ForeColor = Properties.Settings.Default.TextColor;
            ProductAmount_lbl.Font = Properties.Settings.Default.TextFont;
            ProductManuf_lbl.ForeColor = Properties.Settings.Default.TextColor;
            ProductManuf_lbl.Font = Properties.Settings.Default.TextFont;
            ProductName_lbl.ForeColor = Properties.Settings.Default.TextColor;
            ProductName_lbl.Font = Properties.Settings.Default.TextFont;
            ProductPrice_lbl.ForeColor = Properties.Settings.Default.TextColor;
            ProductPrice_lbl.Font = Properties.Settings.Default.TextFont;
            ProductAmount_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ProductAmount_tbox.Font = Properties.Settings.Default.TextFont;
            ProductManuf_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ProductManuf_tbox.Font = Properties.Settings.Default.TextFont;
            ProductName_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ProductName_tbox.Font = Properties.Settings.Default.TextFont;
            ProductPrice_tbox.ForeColor = Properties.Settings.Default.TextColor;
            ProductPrice_tbox.Font = Properties.Settings.Default.TextFont;
            CreateProduct_Btn.ForeColor = Properties.Settings.Default.TextColor;
            CreateProduct_Btn.Font = Properties.Settings.Default.TextFont;
        }

        private void CreateProduct_Btn_Click(object sender, EventArgs e)
        {
            using (MyModel db = new MyModel())
            {
                Products products = new Products();
                products.SetProduct(ProductName_tbox.Text, ProductManuf_tbox.Text, Convert.ToDouble(ProductPrice_tbox.Text), Convert.ToInt32(ProductAmount_tbox.Text));
                db.Products.Add(products);
                db.SaveChanges();
            }
        }
    }
}
