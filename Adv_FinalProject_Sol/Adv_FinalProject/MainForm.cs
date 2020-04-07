using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Entity;


namespace Adv_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void x800x600ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 800;
            Properties.Settings.Default.MFHeight = 600;
            Upd_Size();
        }

        private void x1024x768ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1024;
            Properties.Settings.Default.MFHeight = 768;
            Upd_Size();
        }

        private void x1280x1024ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1280;
            Properties.Settings.Default.MFHeight = 1024;
            Upd_Size();
        }

        private void x1366x768ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1366;
            Properties.Settings.Default.MFHeight = 768;
            Upd_Size();
        }

        private void x1440x900ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1440;
            Properties.Settings.Default.MFHeight = 900;
            Upd_Size();
        }

        private void x1400x1050ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1400;
            Properties.Settings.Default.MFHeight = 1050;
            Upd_Size();
        }

        private void x1600x900ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1600;
            Properties.Settings.Default.MFHeight = 900;
            Upd_Size();
        }

        private void x1680x1050ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1680;
            Properties.Settings.Default.MFHeight = 900;
            Upd_Size();
        }

        private void x1920x1080ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MFWidth = 1920;
            Properties.Settings.Default.MFHeight = 1080;
            Upd_Size();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            Properties.Settings.Default.MFColor = dialog.Color;
            MainForm.ActiveForm.BackColor = Properties.Settings.Default.MFColor;

        }
        private void Upd_Size()
        {
            MainForm.ActiveForm.Width = Properties.Settings.Default.MFWidth;
            MainForm.ActiveForm.Height = Properties.Settings.Default.MFHeight;
        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
