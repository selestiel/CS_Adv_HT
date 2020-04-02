using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


//Work with text Task1
namespace Adv_L10_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Login: ");
            string logn = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string pass = Console.ReadLine();
            MyClass myClass = new MyClass();
            myClass.SetLogin_Password(logn,pass);
            myClass.GetLogin_Password();
            Console.ReadKey();
        }
    }
    class MyClass
    {
        string login {get;set;}
        string password { get; set; }
        public void SetLogin_Password(string login, string password)
        {
            Regex lgn = new Regex(@"[A-Za-z]+");
            if(lgn.IsMatch(login))
            {
                this.login = login;
            }
            Regex pwd = new Regex(@"[0-9]+\W+\D+");
            if (pwd.IsMatch(password))
            {
                this.password = password;
            }
        }
        public void GetLogin_Password()
        {
            Console.WriteLine("login: {0}, Password: {1}",this.login,this.password);
        }
        
    }
}
