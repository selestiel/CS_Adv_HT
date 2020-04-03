using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Adv_L10_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            #region RegionInfo
            RegionInfo region_US = new RegionInfo("US");
            Console.WriteLine( "   Name:                         {0}", region_US.Name );
            Console.WriteLine( "   DisplayName:                  {0}", region_US.DisplayName );
            Console.WriteLine( "   EnglishName:                  {0}", region_US.EnglishName );
            Console.WriteLine( "   IsMetric:                     {0}", region_US.IsMetric );
            Console.WriteLine( "   ThreeLetterISORegionName:     {0}", region_US.ThreeLetterISORegionName );
            Console.WriteLine( "   ThreeLetterWindowsRegionName: {0}", region_US.ThreeLetterWindowsRegionName );
            Console.WriteLine( "   TwoLetterISORegionName:       {0}", region_US.TwoLetterISORegionName );
            Console.WriteLine( "   CurrencySymbol:               {0}", region_US.CurrencySymbol );
            Console.WriteLine( "   ISOCurrencySymbol:            {0}", region_US.ISOCurrencySymbol );
            Console.WriteLine();
            RegionInfo region_UA = new RegionInfo("UA");
            Console.WriteLine("   Name:                         {0}", region_UA.Name);
            Console.WriteLine("   DisplayName:                  {0}", region_UA.DisplayName);
            Console.WriteLine("   EnglishName:                  {0}", region_UA.EnglishName);
            Console.WriteLine("   IsMetric:                     {0}", region_UA.IsMetric);
            Console.WriteLine("   ThreeLetterISORegionName:     {0}", region_UA.ThreeLetterISORegionName);
            Console.WriteLine("   ThreeLetterWindowsRegionName: {0}", region_UA.ThreeLetterWindowsRegionName);
            Console.WriteLine("   TwoLetterISORegionName:       {0}", region_UA.TwoLetterISORegionName);
            Console.WriteLine("   CurrencySymbol:               {0}", region_UA.CurrencySymbol);
            Console.WriteLine("   ISOCurrencySymbol:            {0}", region_UA.ISOCurrencySymbol);
            Console.WriteLine();
            #endregion RegionInfo
            OUTPUT_UA_EN();
            OUTPUT_UA_NA();
            OUTPUT_US_EN();
            OUTPUT_US_NA();
            Console.ReadKey();
        }
        static void OUTPUT_US_EN()
        {
            RegionInfo region_US = new RegionInfo("US");
            FileStream file = new FileStream("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L10_Sol/Adv_L10_T5/Receipt.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string A = Regex.Replace(reader.ReadLine(), @"\bUAH\b", region_US.CurrencyEnglishName + " " + region_US.CurrencySymbol);
                Console.WriteLine(A);
            }
            reader.Close();
            file.Close();

        }
        static void OUTPUT_US_NA()
        {
            RegionInfo region_US = new RegionInfo("US");
            FileStream file = new FileStream("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L10_Sol/Adv_L10_T5/Receipt.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string A = Regex.Replace(reader.ReadLine(), @"\bUAH\b", region_US.CurrencyNativeName + " " + region_US.CurrencySymbol);
                Console.WriteLine(A);
            }
            reader.Close();
            file.Close();

        }
        static void OUTPUT_UA_EN()
        {
            RegionInfo region_UA = new RegionInfo("UA");
            FileStream file = new FileStream("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L10_Sol/Adv_L10_T5/Receipt.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string A = Regex.Replace(reader.ReadLine(), @"\bUAH\b", region_UA.CurrencyEnglishName + " " + region_UA.CurrencySymbol);
                Console.WriteLine(A);
            }
            reader.Close();
            file.Close();

        }
        static void OUTPUT_UA_NA()
        {
            RegionInfo region_UA = new RegionInfo("UA");
            FileStream file = new FileStream("D:/CPPDEV/VSComC#A/CS_Adv_HT/Adv_L10_Sol/Adv_L10_T5/Receipt.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string A = Regex.Replace(reader.ReadLine(), @"\bUAH\b", region_UA.CurrencyNativeName +" "+ region_UA.CurrencySymbol);
                Console.WriteLine(A);
            }
            reader.Close();
            file.Close();

        }
    }
}
