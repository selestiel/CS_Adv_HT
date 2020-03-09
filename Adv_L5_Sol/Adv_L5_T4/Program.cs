using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Adv_L5_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CarDBContext>());
            

            using (CarDBContext db = new CarDBContext())
            {
                CarType T1 = new CarType { TypeID = 1, TypeName = "Porshe" };
                CarModel M1 = new CarModel { ModelID = 1, ModelName = "Corvet" };
                CarColor C1 = new CarColor { ColorID = 1, ColorName = "White" };

                CarType T2 = new CarType { TypeID = 2, TypeName = "Ford" };
                CarModel M2 = new CarModel { ModelID = 2, ModelName = "Sedan" };
                CarColor C2 = new CarColor { ColorID = 2, ColorName = "Red" };

                CarType T3 = new CarType { TypeID = 3, TypeName = "Toyota" };
                CarModel M3 = new CarModel { ModelID = 3, ModelName = "Hutchback" };
                CarColor C3 = new CarColor { ColorID = 3, ColorName = "Blue" };

                CarType T4 = new CarType { TypeID = 4, TypeName = "Nissan" };
                CarModel M4 = new CarModel { ModelID = 4, ModelName = "Sportcar" };
                CarColor C4 = new CarColor { ColorID = 4, ColorName = "Green" };


                db.Types.AddRange(new List<CarType> { T1, T2, T3, T4 });

                db.Models.AddRange(new List<CarModel> { M1, M2, M3, M4 });

                db.Colors.AddRange(new List<CarColor> { C1, C2, C3, C4 });
                db.SaveChanges();

                CarType Type1 = new CarType();
                Type1.Models.Add(M1);
                Type1.Models.Add(M2);
                Type1.Colors.Add(C1);
                Type1.Colors.Add(C2);
                CarType Type2 = new CarType();
                Type2.Models.Add(M3);
                Type2.Models.Add(M4);
                Type2.Colors.Add(C3);
                Type2.Colors.Add(C4);
                CarModel Model1 = new CarModel();
                Model1.Types.Add(T1);
                Model1.Types.Add(T2);
                Model1.Colors.Add(C1);
                Model1.Colors.Add(C2);
                CarModel Model2 = new CarModel();
                Model2.Types.Add(T3);
                Model2.Types.Add(T4);
                Model2.Colors.Add(C3);
                Model2.Colors.Add(C4);
                CarColor Color1 = new CarColor();
                Color1.Types.Add(T1);
                Color1.Types.Add(T2);
                Color1.Models.Add(M1);
                Color1.Models.Add(M2);
                CarColor Color2 = new CarColor();
                Color2.Types.Add(T3);
                Color2.Types.Add(T4);
                Color2.Models.Add(M3);
                Color2.Models.Add(M4);

                db.Types.AddRange(new List<CarType> { Type1, Type2 });
                db.Models.AddRange(new List<CarModel> { Model1, Model2 });
                db.Colors.AddRange(new List<CarColor> { Color1, Color2 });

                db.SaveChanges();

                foreach (var itemT in db.Types.Include(t => t.Models).Include(t => t.Colors))
                {
                    Console.WriteLine(@"Type ID: {0}     Type Name: {1}", itemT.TypeID, itemT.TypeName);

                    if (itemT.Models == null) continue;

                    foreach (var itemM in itemT.Models)
                    {
                        Console.WriteLine(@"Model ID: {0}     Model Name: {1}", itemM.ModelID, itemM.ModelName);
                    }
                    if (itemT.Colors == null) continue;

                    foreach (var itemC in itemT.Colors)
                    {
                        Console.WriteLine(@"Color ID: {0}     Color Name: {1}", itemC.ColorID, itemC.ColorName);
                    }
                    Console.WriteLine(new string('-', 30));
                }

                Console.WriteLine(new string('*', 30));

                foreach (var itemM in db.Models.Include(m => m.Types).Include(m => m.Colors))
                {
                    Console.WriteLine(@"Model ID: {0}     Model Name: {1}", itemM.ModelID, itemM.ModelName);

                    if (itemM.Types == null) continue;

                    foreach (var itemT in itemM.Types)
                    {
                        Console.WriteLine(@"Type ID: {0}     Type Name: {1}", itemT.TypeID, itemT.TypeName);
                    }
                    if (itemM.Colors == null) continue;

                    foreach (var itemC in itemM.Colors)
                    {
                        Console.WriteLine(@"Color ID: {0}     Color Name: {1}", itemC.ColorID, itemC.ColorName);
                    }
                    Console.WriteLine(new string('-', 30));
                }
                Console.WriteLine(new string('*', 30));

                foreach (var itemC in db.Colors.Include(c => c.Types).Include(c => c.Models))
                {
                    Console.WriteLine(@"Color ID: {0}     Color Name: {1}", itemC.ColorID, itemC.ColorName);

                    if (itemC.Types == null) continue;

                    foreach (var itemT in itemC.Types)
                    {
                        Console.WriteLine(@"Type ID: {0}     Type Name: {1}", itemT.TypeID, itemT.TypeName);
                    }
                    if (itemC.Models == null) continue;

                    foreach (var itemM in itemC.Models)
                    {
                        Console.WriteLine(@"Model ID: {0}     Model Name: {1}", itemM.ModelID, itemM.ModelName);
                    }
                    Console.WriteLine(new string('-', 30));
                }
                Console.WriteLine(new string('*', 30));
                Console.ReadKey();
            }
        }
    }
}
