using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace ClientClassNS
{
    [Serializable]
    [XmlRoot("ClientClass")]
    public class ClientClass
    {
        [XmlElement]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlIgnore]
        public double Age { get; set; }
        
        public void Info()
        {
            Console.WriteLine(@"Object ID: {0} Name: {1} Age: {2}",ID,Name,Age);
        }
    }
}
