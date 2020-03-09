using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adv_L7_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("MyFile", FileMode.OpenOrCreate, FileAccess.Write,FileShare.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Fully implemented dominator system based on few age 3225 modifications.");
            writer.WriteLine("And thus the new Age has begun evolving entire world in some thing new, something chaotic!");
            writer.Close();
            stream.Close();
            if (File.Exists("MyFile") == true)
            {
                FileStream stream1 = new FileStream("MyFile", FileMode.Open, FileAccess.Read,FileShare.Read);
                StreamReader reader = new StreamReader(stream1);
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
                stream1.Close();
            }
            Console.ReadKey();
        }
    }
}
