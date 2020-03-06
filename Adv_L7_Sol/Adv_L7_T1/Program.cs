using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adv_L7_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                Directory.CreateDirectory(string.Concat("D:/NewDirectory/Folders", i));
                DirectoryInfo infod = new DirectoryInfo(string.Concat("D:/NewDirectory/Folders", i));
                Console.WriteLine(infod.FullName);
                Console.WriteLine(infod.Attributes);
                Console.WriteLine(infod.CreationTimeUtc);
                Console.WriteLine(infod.LastAccessTimeUtc);
                Console.WriteLine(infod.LastWriteTimeUtc);
                Console.WriteLine(infod.Parent);
                Console.WriteLine(infod.Root);

            }
            for (int i = 1; i <= 50; i++)
            {
                Directory.Delete(string.Concat("D:/NewDirectory/Folders", i));
            }
                Directory.Delete("D:/NewDirectory");
                Console.ReadKey();
        }
    }
}
