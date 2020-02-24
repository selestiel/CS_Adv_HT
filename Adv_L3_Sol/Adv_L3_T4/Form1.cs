using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Adv_L3_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        class MyTime
        {
             //static public int mss = 0;
             static public int sec = 0;
             static public int min = 0;
             static public int hrs = 0;
             static public int days = 0;
            static public int years = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //MyTime.mss +=1000;
            MyTime.sec++;
            MyTime.min = MyTime.sec / 60;
            MyTime.hrs = MyTime.min / 60;
            MyTime.days = MyTime.hrs / 24;
            MyTime.years = MyTime.days / 365;
            textBox1.Text = String.Format(@"{0} years : {1} days : {2} hours : {3} minutes : {4} seconds",MyTime.years, MyTime.days, MyTime.hrs, MyTime.min, MyTime.sec);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            //MyTime.mss = 0;
            MyTime.sec = 0;
            MyTime.min = 0;
            MyTime.hrs = 0;
            MyTime.days = 0;
            MyTime.years = 0;
        }

        private void Btn_Stop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void LBL_TimeNow_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LBL_TimeNow.Text = DateTime.Now.ToString(@"dd:MM:yyyy   HH:mm:ss");
        }
    }
}
