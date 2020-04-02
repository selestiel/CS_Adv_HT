using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UserClassNS;

namespace Adv_L10_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserClass));
            UserClass User1 = new UserClass();
            User1.ID = 55;
            User1.Name = "Beggek";
            User1.Age = 205.22;
            UserClass User2;
            //dlya for xml filling

            FileStream stream = new FileStream("User1File.xml", FileMode.Create, FileAccess.Write, FileShare.Read);

            serializer.Serialize(stream, User1);
            Console.WriteLine("Serialized!");
            stream.Close();

            FileStream stream1 = new FileStream("User1File.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            User2 = serializer.Deserialize(stream1) as UserClass;
            Console.WriteLine("Deserialized");
            User2.Info();

        }
    }
}
