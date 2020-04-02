using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
namespace Adv_L8_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader Reader = new XmlTextReader("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L8_Sol/Adv_L8_T1/bin/Debug/TelephoneBook.xml");
            while (Reader.Read())
            {
                switch (Reader.NodeType)
                {
                    case XmlNodeType.Element: 
                        Console.Write("<" + Reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(Reader.Name + " " + Reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + Reader.Name);
                        Console.WriteLine(">");
                        break;
                }
               
            }
            XmlDocument xml = new XmlDocument();
            xml.Load("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L8_Sol/Adv_L8_T1/bin/Debug/TelephoneBook.xml");
            XmlNodeList nodeList = xml.SelectNodes("/MyContacts/*");
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine(node.Attributes["Name"].Value + " " + node.Attributes["TelephoneNumber"].Value);
            }
            Console.WriteLine(Reader.BaseURI);
            Console.WriteLine(Reader.Namespaces);
            Console.WriteLine(Reader.LocalName);
            Console.ReadKey();
        }
    }
}
