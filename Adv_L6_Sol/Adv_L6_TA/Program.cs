using System;
using System.IO;
using System.Reflection;
namespace Adv_L6_TA
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.Load("Adv_L6_T1");
                Console.WriteLine("Assembly Adv_L6_T1 sucsessfully loaded");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Получения информации о всех типах в сборке.
            GetInfoAboutAllTypes(assembly);

            // Получения информации о членах класса.
            GetInfoAboutAllMembers(assembly);

            // Получения информации о  о параметрах для метода.
            GetMethodsParams(assembly);

            //Задержка
            Console.ReadKey();
        }

        #region GetInfoAboutAllTypes - Получения информации о всех типах в сборке.
        /// <summary>
        /// Получения информации о всех типах в сборке.
        /// </summary>
        public static void GetInfoAboutAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 10));
            Console.WriteLine("\nTypes in: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Full Name:             {0}", type.FullName);
                Console.WriteLine("This is Class:              {0}", type.IsClass);
            }
        }
        #endregion

        #region GetInfoAboutAllMembers - Получения информации о членах класса.
        /// <summary>
        /// Получения информации о членах класса.
        /// </summary>
        public static void GetInfoAboutAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 10));

            Type type = assembly.GetType("Adv_L6_T1.Temp");

            Console.WriteLine("\nClass Members: {0} \n", type.Name);

            MemberInfo[] membersInfo = type.GetMembers();

            foreach (MemberInfo memberInfo in membersInfo)
            {
                Console.WriteLine("{0,-15}:  {1}", memberInfo.MemberType, memberInfo);
            }
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
            Console.WriteLine("\nParameter info for method {0}", method.Name);

            ParameterInfo[] parameters = method.GetParameters();
            Console.WriteLine("Method has " + parameters.Length + " Parameters");

            // Выводим некоторые характеристики каждого из параметров. 
            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine("Parameter Name: {0}", parameter.Name);
                Console.WriteLine("Position at Method: {0}", parameter.Position);
                Console.WriteLine("Paramete Type: {0}", parameter.ParameterType);
            }
        }
        #endregion
    }
}
