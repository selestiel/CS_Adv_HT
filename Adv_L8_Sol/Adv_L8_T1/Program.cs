using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Adv_L8_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            new XDocument(new XElement("MyContacts",
                new XElement("Contact", new XAttribute("Name", "Joker"),
                new XAttribute("TelephoneNumber", "123165464987")))).Save("TelephoneBook.xml");
        }
    }
}
