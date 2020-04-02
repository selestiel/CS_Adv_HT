using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Adv_L7_T3
{
    //Final ver....
    class Program
    {
        static void Main(string[] argss)
        {
            int trycount = 0;
            bool flag_a = false;
            string[] files = null;
            do
            {
                bool flag_b = false;
                Console.WriteLine("Enter directory to look at: ");
                string DirectoryNow = Console.ReadLine();
                do
                {
                    Console.Write("Enter filename: ");
                    string FileName = Console.ReadLine();
                    Console.WriteLine(Environment.NewLine);
                    try
                    {
                        files = Directory.GetFiles(DirectoryNow, FileName, SearchOption.AllDirectories);
                        if (files.Length == 0)
                        {
                            Console.WriteLine("File not found! Retry: ");
                            flag_b = true;
                            trycount++;
                        }else if (trycount == 10)
                        {
                            flag_a = true;
                            trycount = 0;
                        }
                        else
                        {
                            Console.WriteLine("Files found: {0}.", files.Length);
                            flag_b = false;
                            flag_a = false;
                        }

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        if (e is DirectoryNotFoundException)
                        {
                            flag_a = true;
                        }
                        else if(e is FileNotFoundException)
                        {
                            flag_b = true;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    Console.WriteLine(Environment.NewLine);


                } while (flag_b == true);
            } while (flag_a == true);
                    Console.WriteLine("Choose your operation: ");
                    Console.WriteLine("Read from file: 1");
                    Console.WriteLine("Archive file: 2");
                    Console.WriteLine("Exit: 3");
                    int flag_c = 0;
                    try
                    {
                        flag_c = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ein)
                    {
                        Console.WriteLine(ein.Message);
                    }
                    switch (flag_c)
                    {
                        case 1:
                            foreach (var item_file in files)
                            {
                                FileStream stream = new FileStream(item_file, FileMode.Open, FileAccess.Read);
                                byte[] array = null;
                                using (stream = File.OpenRead(item_file))
                                {
                                    array = new byte[item_file.Length];
                                    
                                    stream.Read(array, 0, array.Length);
                                    
                                    string ByteToString = Encoding.Default.GetString(array);
                                    Console.WriteLine(@"Text here: {0}", ByteToString);
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            foreach (var item_file in files)
                            {
                                FileStream fileStream = File.OpenRead(item_file);
                                DirectoryInfo fileinfo = new DirectoryInfo(item_file);
                                string files_compr = String.Format(@"{0}\{1}.zip",fileinfo.Parent.FullName,Path.GetFileNameWithoutExtension(fileinfo.Name));
                                if (!File.Exists(files_compr))
                                {
                                    FileStream output_folder = File.Create(files_compr);
                                    GZipStream zipStream = new GZipStream(output_folder, CompressionMode.Compress);
                                    int bytereader = fileStream.ReadByte();
                                    while (bytereader != -1)
                                    {
                                        zipStream.WriteByte((byte)bytereader);
                                        bytereader = fileStream.ReadByte();
                                    }
                                    zipStream.Close();
                                    Console.WriteLine("Compressing complete.");
                                    Console.WriteLine("Compressed file: {0}",output_folder.Name);
                                }
                                else
                                {
                                    Console.WriteLine("File already exists.");
                                }
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
        }
    }
}



