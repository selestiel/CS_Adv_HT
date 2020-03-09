using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Adv_L8_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument(new XElement("TextBox"));
            doc.Root.Add(new XText(richTextBox1.Text));
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
