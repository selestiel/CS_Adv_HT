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
using System.Xml;
using Microsoft.Win32;
using System.Configuration;
namespace Adv_L8_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetRegSettings();
            Update();
        }



        private new void Update()
        {
            this.richTextBox1.BackColor = Properties.Settings.Default.BoxColor;
            this.richTextBox1.ForeColor = Properties.Settings.Default.TextColor;
            this.BackColor = Properties.Settings.Default.BackColor;
            this.richTextBox1.Font = new Font(Properties.Settings.Default.Font.Name,Convert.ToSingle(Properties.Settings.Default.Font.Size));
        }
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.ShowDialog();
            richTextBox1.ForeColor = colorDialog.Color;
            Properties.Settings.Default.TextColor = richTextBox1.ForeColor;
        }

        private void boxColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.ShowDialog();
            richTextBox1.BackColor = colorDialog.Color;
            Properties.Settings.Default.BoxColor = richTextBox1.BackColor;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.ShowDialog();
            Form1.ActiveForm.BackColor = colorDialog.Color;
            Properties.Settings.Default.BackColor = Form1.ActiveForm.BackColor;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetXmlSettings();
        }
        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetXmlSettings();
            Update();
        }
        private void saveToRegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRegSettings();
        }

        private void loadFromRegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRegSettings();
            Update();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox1.Font = font.Font;
            Properties.Settings.Default.Font = richTextBox1.Font;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRegSettings();
            Update();
            
        }
        private void SetXmlSettings()
        {
            XDocument doc = new XDocument(new XElement("Application"));
            doc.Root.Add(new XElement("CongigurationSettings"));
            doc.Root.LastNode.AddAfterSelf(new XElement("BackColor",
                new XAttribute("BackColorA", Properties.Settings.Default.BackColor.A),
                new XAttribute("BackColorR", Properties.Settings.Default.BackColor.R),
                new XAttribute("BackColorG", Properties.Settings.Default.BackColor.G),
                new XAttribute("BackColorB", Properties.Settings.Default.BackColor.B)));
            doc.Root.LastNode.AddAfterSelf(new XElement("BoxColor",
                new XAttribute("BoxColorA", Properties.Settings.Default.BoxColor.A),
                new XAttribute("BoxColorR", Properties.Settings.Default.BoxColor.R),
                new XAttribute("BoxColorG", Properties.Settings.Default.BoxColor.G),
                new XAttribute("BoxColorB", Properties.Settings.Default.BoxColor.B)));
            doc.Root.LastNode.AddAfterSelf(new XElement("TextColor",
                new XAttribute("TextColorA", Properties.Settings.Default.TextColor.A),
                new XAttribute("TextColorR", Properties.Settings.Default.TextColor.R),
                new XAttribute("TextColorG", Properties.Settings.Default.TextColor.G),
                new XAttribute("TextColorB", Properties.Settings.Default.TextColor.B)));
            doc.Root.LastNode.AddAfterSelf(new XElement("TextFont",
                new XAttribute("FontName", Properties.Settings.Default.Font.Name),
                new XAttribute("FontSize", Properties.Settings.Default.Font.Size)));
            doc.Save("AppConfig.xml");
            Properties.Settings.Default.Save();

        }
        private void GetXmlSettings()
        {
            XmlTextReader reader = new XmlTextReader("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L8_Sol/Adv_L8_T4/bin/Debug/AppConfig.xml");
            reader.Read();
            Properties.Settings.Default.BackColor = Color.FromArgb(
                Convert.ToInt32(reader.GetAttribute("BackColorA")),
                Convert.ToInt32(reader.GetAttribute("BackColorR")),
                Convert.ToInt32(reader.GetAttribute("BackColorG")),
                Convert.ToInt32(reader.GetAttribute("BackColorB")));
            Properties.Settings.Default.BoxColor = Color.FromArgb(
                Convert.ToInt32(reader.GetAttribute("BoxColorA")),
                Convert.ToInt32(reader.GetAttribute("BoxColorR")),
                Convert.ToInt32(reader.GetAttribute("BoxColorG")),
                Convert.ToInt32(reader.GetAttribute("BoxColorB")));
            Properties.Settings.Default.TextColor = Color.FromArgb(
                Convert.ToInt32(reader.GetAttribute("TextColorA")),
                Convert.ToInt32(reader.GetAttribute("TextColorR")),
                Convert.ToInt32(reader.GetAttribute("TextColorG")),
                Convert.ToInt32(reader.GetAttribute("TextColorB")));
            Properties.Settings.Default.Font = new Font(reader.GetAttribute("FontName"),
                float.Parse(reader.GetAttribute("FontSize")));
            reader.Close();
            Properties.Settings.Default.Reload();
            
        }
        private void SetRegSettings()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey Application = currentUserKey.CreateSubKey("Application");
            Application.SetValue("BackColor", Properties.Settings.Default.BackColor.Name);
            Application.SetValue("BoxColor", Properties.Settings.Default.BoxColor.Name);
            Application.SetValue("TextColor", Properties.Settings.Default.TextColor.Name);
            Application.SetValue("TextFont", Properties.Settings.Default.Font.Name);
            Application.SetValue("TextSize", Properties.Settings.Default.Font.Size);
            Application.Close();
            Properties.Settings.Default.Save();
        }
        private void GetRegSettings()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey Application = currentUserKey.OpenSubKey("Application");
            Properties.Settings.Default.BackColor = Color.FromName(Application.GetValue("BackColor").ToString());
            Properties.Settings.Default.BoxColor = Color.FromName(Application.GetValue("BoxColor").ToString());
            Properties.Settings.Default.TextColor = Color.FromName(Application.GetValue("TextColor").ToString());
            Properties.Settings.Default.Font = new Font(Application.GetValue("TextFont").ToString(), Convert.ToSingle(Application.GetValue("TextSize").ToString()));
            Application.Close();
            Properties.Settings.Default.Reload();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetRegSettings();
        }
    }
}
