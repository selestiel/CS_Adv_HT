using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Adv_L8_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L8_Sol/Adv_L8_T1/bin/Debug/TelephoneBook.xml");
            XmlNodeList nodeList = xml.SelectNodes("/MyContacts/*");
            foreach (XmlNode node in nodeList)
            {     
                Console.WriteLine(node.Attributes["TelephoneNumber"].Value);   
            }
            Console.ReadKey();
        }
    }
}
