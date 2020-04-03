using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UserClassNS;

namespace Adv_L10_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClass user1 = new UserClass() { Age = 35, ID = 5, Name = "Greg" };
            UserClass user2 = new UserClass() { Name = "Lola", Age = 50, ID = 661 };
            Serialize_XML1(user1);
            Serialize_XML1(user2);
            Serialize_XMl2(user1);
            Serialize_XMl2(user2);
            ClientClassNS.ClientClass client1 = new ClientClassNS.ClientClass { Age = 87, ID = 009, Name = "Honoo" };
            ClientClassNS.ClientClass client2 = new ClientClassNS.ClientClass { Name = "Jokes", Age = 336, ID = 52815 };
            Serialize_XML1(client1);
            Serialize_XMl2(client2);
            Console.ReadKey();

        }
        static public void Serialize_XML1(UserClass user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserClass));
            using (TextWriter writer = new StreamWriter($@"Xml_Serialize_A_{user.ID}.xml"))
            {
                serializer.Serialize(writer, user);
            }
            Console.WriteLine("XML_Serialized");
        }
        static public void Serialize_XMl2(UserClass user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserClass));
            FileStream stream = new FileStream($@"Xml_Serialize_B_{user.ID}.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            serializer.Serialize(stream, user);
            Console.WriteLine("Object serialized!");
            stream.Close();
        }
        static public void Serialize_XML1(ClientClassNS.ClientClass user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClientClassNS.ClientClass));
            using (TextWriter writer = new StreamWriter($@"Xml_Serialize_C_{user.ID}.xml"))
            {
                serializer.Serialize(writer, user);
            }
            Console.WriteLine("XML_Serialized");
        }
        static public void Serialize_XMl2(ClientClassNS.ClientClass user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClientClassNS.ClientClass));
            FileStream stream = new FileStream($@"Xml_Serialize_D_{user.ID}.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            serializer.Serialize(stream, user);
            Console.WriteLine("Object serialized!");
            stream.Close();
        }
    }
}
