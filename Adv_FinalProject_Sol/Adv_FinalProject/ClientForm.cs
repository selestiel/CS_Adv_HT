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
            Username_lbl.Text = Properties.Settings.Default.LoggedInName;
        }

        private void AddMoney_Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void AddOrder_Btn_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder();
            order.Show();
        }
    }
}
