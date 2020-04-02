using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_L9_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.Info();
            Manager manager = new Manager();
            manager.Info();
            Programmer programmer = new Programmer();
            programmer.Info();

            Console.ReadKey();

        }
    }
    class Director
    {
        [AccessLevel(AccessLevelAttribute.User.Director)]
        public void Info()
        {
            AccessLevelAttribute attribute = new AccessLevelAttribute(AccessLevelAttribute.User.Director);
            Console.WriteLine("Director: Access Level: ");
            attribute.GetLevel();
            
        }
    }
    class Manager
    {
        [AccessLevel(AccessLevelAttribute.User.Manager)]
        public void Info()
        {
            AccessLevelAttribute attribute = new AccessLevelAttribute(AccessLevelAttribute.User.Manager);
            Console.WriteLine("Manager: Access Level: ");
            attribute.GetLevel();

        }
    }
    class Programmer
    {
        [AccessLevel(AccessLevelAttribute.User.Programmer)]
        public void Info()
        {
            AccessLevelAttribute attribute = new AccessLevelAttribute(AccessLevelAttribute.User.Programmer);
            Console.WriteLine("Programmer: Access Level: ");
            attribute.GetLevel();

        }
    }
    class AccessLevelAttribute : System.Attribute
    {
        AccessLevelE level { get; set; }
        enum AccessLevelE
        {
            SSS,
            SS,
            S,
            A,
            B,
            C,
            D,
            E,
            F
        };
        public enum User
        {
            Manager, Programmer, Director
        };
        public void GetLevel()
        {
            Console.WriteLine(this.level);
        }
        private AccessLevelE AccsessLevel(User user)
        { 
            switch (user)
            {
                case User.Director:
                    level = AccessLevelE.A;
                    break;
                case User.Manager:
                    level = AccessLevelE.E;
                    break;
                case User.Programmer:
                    level = AccessLevelE.SSS;
                    break;
            }
            return level;
        }
        public AccessLevelAttribute(User u)
        {

            this.AccsessLevel(u);
        }
    }
}
