using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace UserClassNS
{
    
    class UserClass
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public void Info()
        {
            Console.WriteLine(@"Object ID: {0} Name: {1} Age: {2}",ID,Name,Age);
        }
    }
}
