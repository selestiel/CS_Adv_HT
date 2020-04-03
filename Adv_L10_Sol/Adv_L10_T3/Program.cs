using System.IO;
using System.Xml.Serialization;
using UserClassNS;
using System;
namespace Adv_L10_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deserialize_XML();
            Console.ReadKey();
        }
        static void Deserialize_XML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(UserClass));
            TextReader reader = new StreamReader(@"D:\CPPDEV\VSComC#A\CS_Adv_HT\Adv_L10_Sol\Adv_L10_T2\bin\Debug\Xml_Serialize_A_5.xml");
            object obj = deserializer.Deserialize(reader);
            UserClass XmlData = (UserClass)obj;
            XmlData.Info();
            Console.WriteLine("Object Deserialized");
            reader.Close();
        }
    }
}
