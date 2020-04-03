using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UserClassNS;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Adv_L10_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClass User1 = new UserClass();
            User1.ID = 55;
            User1.Name = "Beggek";
            User1.Age = 205.22;
            Serialize_XML(User1);
            Serialize_Binary(User1);
            Serialize_SOAP(User1);
            UserClass User2 = new UserClass() { ID = 99, Age = 900, Name = "Bohhii"};
            Serialize_XML(User2);
            Serialize_Binary(User2);
            Serialize_SOAP(User2);

            Console.ReadKey();


        }
        static public void Serialize_XML(UserClass user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserClass));
            using (TextWriter writer = new StreamWriter($@"Xml_Serialize{user.ID}.xml"))
            {
                serializer.Serialize(writer, user);
            }
            Console.WriteLine("XML_Serialized");
        }
        static public void Serialize_Binary(UserClass user)
        {
            FileStream stream = new FileStream($@"Serialize_Bin{user.ID}.dat", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, user);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
                Console.WriteLine("Binary Serialized");
            }
        }
        static public void Serialize_SOAP(UserClass user)
        {
            SoapFormatter formatter = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream stream = new FileStream($@"Seialization_Soap{user.ID}.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, user);

                Console.WriteLine("Object Seialized");
            }
        }
    }
}
