using System;
using System.IO;
using System.Reflection;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Adv_L6_T1;

namespace Adv_L6_T3
{
    public partial class Form1 : Form
    {
        #region MESSAGES
        public static string Message1 { get; set; }
        public static string Message2 { get; set; }
        public static string Message3 { get; set; }
        public static string Message3a { get; set; }
        public static string Message3b { get; set; }
        public static string Message4 { get; set; }
        public static string Message5 { get; set; }
        public static string Message6 { get; set; }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        #region GetInfoAboutAllTypes - Получения информации о всех типах в сборке.
        /// <summary>
        /// Получения информации о всех типах в сборке.
        /// </summary>
        public static void GetInfoAboutAllTypes(Assembly assembly)
        {
            Message1 = "\nTypes in: \n" + assembly.FullName + "\n";

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Message2 += "Full Name:             " + "\t" + type.FullName + "\n";
                Message3 += "This is Class:         " + "\t" + type.IsClass + "\n";
            }
            Message4 = Message1 + "\n" + Message2 + "\n" + Message3;
        }
        #endregion

        #region GetInfoAboutAllMembers - Получения информации о членах класса.
        /// <summary>
        /// Получения информации о членах класса.
        /// </summary>
        public static void GetInfoAboutAllMembers(Assembly assembly)
        {

            Type type = assembly.GetType("Adv_L6_T1.Temp");

            Message1 = "\nClass Members: \n" + type.Name + "\n";

            MemberInfo[] membersInfo = type.GetMembers();

            foreach (MemberInfo memberInfo in membersInfo)
            {
                Message2 += "\t" + memberInfo.MemberType + "\t" + memberInfo + "\n";
            }
            Message5 = Message1 + "\n" + Message2;
        }
        #endregion

        #region GetMethodsParams - Получения информации о  о параметрах для метода.
        /// <summary>
        /// Получения информации о  о параметрах для метода.
        /// </summary>
        public static void GetMethodsParams(Assembly assembly)
        {
            Type type = assembly.GetType("Adv_L6_T1.Temp");

            MethodInfo method = type.GetMethod("GetTemp"); // Equals , Acceleration, Driver

            // Вывод информации о количестве параметров.
            Message1 = "\nParameter info for method " + "\t" + method.Name + "\n";

            ParameterInfo[] parameters = method.GetParameters();
            Message2 = "Method has " + parameters.Length + " Parameters" + "\n";

            // Выводим некоторые характеристики каждого из параметров. 
            foreach (ParameterInfo parameter in parameters)
            {
                Message3 += "Parameter Name: " + "\t" + parameter.Name + "\n";
                Message3a += "Position at Method: " + "\t" + parameter.Position + "\n";
                Message3b += "Paramete Type: " + "\t" + parameter.ParameterType + "\n";
            }
            Message6 = Message1 + "\n" + Message2 + "\n" + Message3 + "\n" + Message3a + "\n" + Message3b + "\n";
        }
        #endregion

        public class ETEMP : Temp
        {
            public override void TempInfo()
            {
                TEXTOUTPUT.Text += TempNameIN.Text + "\t" + TempValueIN.Text + "\n";
            }
           
          
            public override void GetTemp(string name)
            {
                if (name == Celsius.name)
                {
                    TEXTOUTPUT.Text += " Temperature: " + Celsius.name + "\t" + "current: " + Celsius.GetTemp()+ " C\n";
                }
                else if (name == Fahrenheit.name)
                {
                    TEXTOUTPUT.Text += " Temperature: " + Fahrenheit.name + "\t" + "current: " + Fahrenheit.GetTemp() + " C\n";
                }
                else if (name == Kelvin.name)
                {
                    TEXTOUTPUT.Text += " Temperature: " + Kelvin.name + "\t" + "current: " + Kelvin.GetTemp() + " C\n";
                }
                else
                {
                    Console.WriteLine("Not implemented");
                }

            }

        }
        #region Methods
        private void BTN_CVT_Click(object sender, EventArgs e)
        {

            Temp temp = new Temp(); 
            temp.SetTemp("Celsius", 70);
            temp.Convert("Celsius", "Kelvin", temp.TempValue);
            temp.Convert("Celsius", "Fahrenheit", temp.TempValue);

            temp.GetTemp("Kelvin");
            temp.GetTemp("Fahrenheit");
            temp.TempInfo();
            double tempv = System.Convert.ToDouble(TempValueIN.Text);
            temp.SetTemp(TempNameIN.Text, tempv);
            if (TempNameIN.Text == "Celsius")
            {
                temp.Convert("Celsius", "Kelvin", tempv);
                temp.Convert("Celsius", "Fahrenheit", tempv);
            }
            else if (TempNameIN.Text == "Kelvin")
            {
                temp.Convert("Kelvin", "Celsius", tempv);
                temp.Convert("Kelvin", "Fahrenheit", tempv);
            }
            else if (TempNameIN.Text == "Fahrenheit")
            {
                temp.Convert("Fahrenheit", "Celsius", tempv);
                temp.Convert("Fahrenheit", "Kelvin", tempv);
            }
            else
            {
                Console.WriteLine("Not yet Implemented!!!");
            }
            ETEMP etemp = new ETEMP();
            etemp.GetTemp("Celsius");
            etemp.GetTemp("Kelvin");
            etemp.GetTemp("Fahrenheit");
            etemp.TempInfo();


        }

        private void BTN_TypeInfo_Click(object sender, EventArgs e)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.Load("Adv_L6_T1");
                TEXTOUTPUT.Text += "Assembly Adv_L6_T1 sucsessfully loaded";
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Получения информации о всех типах в сборке.
            GetInfoAboutAllTypes(assembly);
            TEXTOUTPUT.Text += Message4 + "\n";
            // Получения информации о членах класса.
            GetInfoAboutAllMembers(assembly);
            TEXTOUTPUT.Text += Message5 + "\n";
            // Получения информации о  о параметрах для метода.
            GetMethodsParams(assembly);
            TEXTOUTPUT.Text += Message6 + "\n";

        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            TEXTOUTPUT.Text = "";
        }
        #endregion
    }
}
