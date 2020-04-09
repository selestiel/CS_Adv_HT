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
using Microsoft.Win32;

namespace Adv_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.MFColor;
            this.Width = Properties.Settings.Default.MFWidth;
            this.Height = Properties.Settings.Default.MFHeight;
            this.Location = Properties.Settings.Default.MFLocation;
            this.ForeColor = Properties.Settings.Default.TextColor; 
            this.Font = new Font(Properties.Settings.Default.TextFont.Name, Convert.ToSingle(Properties.Settings.Default.TextFont.Size));
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
            this.BackColor = Properties.Settings.Default.MFColor;
            Properties.Settings.Default.Save();

        }
        private void Upd_Size()
        {
            this.Width = Properties.Settings.Default.MFWidth;
            this.Height = Properties.Settings.Default.MFHeight;
            Properties.Settings.Default.Save();
        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey Application = currentUserKey.CreateSubKey("MyModelApp");
            Application.SetValue("BackColor", Properties.Settings.Default.MFColor.Name);
            Application.SetValue("FormHeight", Properties.Settings.Default.MFHeight);
            Application.SetValue("FormWidth", Properties.Settings.Default.MFWidth);
            Application.SetValue("FormPositionA", Properties.Settings.Default.MFLocation.X);
            Application.SetValue("FormPositionB", Properties.Settings.Default.MFLocation.Y);
            Application.SetValue("TextColor", Properties.Settings.Default.TextColor.Name);
            Application.SetValue("TextFont", Properties.Settings.Default.TextFont.Name);
            Application.SetValue("TextSize", Properties.Settings.Default.TextFont.Size);
            Application.Close();
            Properties.Settings.Default.Save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey Application = currentUserKey.OpenSubKey("MyModelApp");
            Properties.Settings.Default.MFColor = Color.FromName(Application.GetValue("BackColor").ToString());
            Properties.Settings.Default.MFHeight = Convert.ToInt32(Application.GetValue("FormHeight").ToString());
            Properties.Settings.Default.MFWidth = Convert.ToInt32(Application.GetValue("FormWidth").ToString());
            Properties.Settings.Default.MFLocation = new Point(Convert.ToInt32(Application.GetValue("FormPositionA")), Convert.ToInt32(Application.GetValue("FormPositionB")));
            Properties.Settings.Default.TextColor = Color.FromName(Application.GetValue("TextColor").ToString());
            Properties.Settings.Default.TextFont = new Font(Application.GetValue("TextFont").ToString(), Convert.ToSingle(Application.GetValue("TextSize").ToString()));
            Application.Close();
            Properties.Settings.Default.Reload();
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.ShowDialog();
            this.ForeColor = colorDialog.Color;
            Properties.Settings.Default.TextColor = this.ForeColor;
            Properties.Settings.Default.Save();
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            this.Font = font.Font;
            Properties.Settings.Default.TextFont = this.Font;
            Properties.Settings.Default.Save();
        }
    }
}
