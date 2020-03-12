using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Adv_L5_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MyDBContext>());
            

            using (MyDBContext db = new MyDBContext())
            {
                MyClass2 C1 = new MyClass2 { Name = "Lumber", Count = 50 };
                MyClass2 C2 = new MyClass2 { Name = "Stone", Count = 70 };
                MyClass2 C3 = new MyClass2 { Name = "Food", Count = 80 };
                MyClass2 C4 = new MyClass2 { Name = "Gold", Count = 40 };

                MyClass2 C5 = new MyClass2 { Name = "Lumber", Count = 30 };
                MyClass2 C6 = new MyClass2 { Name = "Stone", Count = 40 };
                MyClass2 C7 = new MyClass2 { Name = "Food", Count = 20 };
                MyClass2 C8 = new MyClass2 { Name = "Gold", Count = 80 };

                db.class2s.AddRange(new List<MyClass2> { C1, C2, C3, C4 });
                db.SaveChanges();

                var clas = db.class2s.ToList();
                #region Base to console
                foreach (var item in clas)
                {
                    Console.WriteLine(@"{0}      {1}        {2}     {3}", item.ID, item.Name, item.Count, item.class1 != null ? item.class1.Name : "No Class");
                }
                #endregion
                Console.WriteLine(new string('-', 30));

                Console.WriteLine(new string('*', 50));
                IEnumerable<MyClass2> MCIE = new List<MyClass2> { C1, C2, C3, C4 };
                Console.WriteLine(clas.First());
                Console.WriteLine(clas.FirstOrDefault());

                clas.OrderBy(t=>t.Name);
                foreach (var item in clas)
                {
                    Console.WriteLine(@"{0}     {1}     {2}", item.Name, item.ID, item.Count);
                }
                Console.WriteLine(clas.Count());

                Console.WriteLine(MCIE.Max(mm=>mm.Count));
                Console.WriteLine(clas.Average(dc=>dc.Count));

                Console.WriteLine(new string('*', 50));

                MyClass1 MC1 = new MyClass1 { Name = "Country1", Count = 6, class2s = new List<MyClass2> { C1, C3, C6, C8 } };

                MyClass1 MC2 = new MyClass1 { Name = "Country2", Count = 10, class2s = new List<MyClass2> { C2, C4, C5, C7 } };

                db.class1s.AddRange(new List<MyClass1> { MC1, MC2 });
                db.SaveChanges();

                var clas2 = db.class2s.ToList();
                #region Output to Console A
                /*foreach (var item in clas2)
                {
                    Console.WriteLine(@"{0}      {1}        {2}     {3}", item.ID, item.Name, item.Count, item.class1 != null ? item.class1.Name : "No Class");
                }

                Console.WriteLine(new string('-', 30));
                Console.ReadKey();

                var clas1 = db.class1s.ToList();

                foreach (var itemC1 in clas1)
                {
                    Console.WriteLine(@"{0}      {1}        {2}     {3}", itemC1.ID, itemC1.Name, itemC1.Count, itemC1.class2s);

                    if (itemC1.class2s == null) continue;

                    foreach (var itemC2 in itemC1.class2s)
                    {
                        Console.WriteLine(@"{0}      {1}        {2}     {3}     {4}", itemC2.ID, itemC2.Name, itemC2.Count, itemC1.Name, itemC1.Count);
                    }

                    Console.WriteLine(new string('-', 30));
                }
                */
                #endregion 
                Console.WriteLine(new string('-',30));

                Console.WriteLine(new string('*',50));
                Console.WriteLine(clas2.First());
                Console.WriteLine(clas2.FirstOrDefault());
                clas2.OrderBy(t => t.Name);
                foreach (var item in clas2)
                {
                    Console.WriteLine(@"{0}     {1}     {2}", item.Name, item.ID, item.Count);
                }
                Console.WriteLine(clas2.Count());
                IEnumerable<MyClass1> MCTIE = new List<MyClass1> { MC1, MC2 };
                Console.WriteLine(MCTIE.Min(mn=>mn.Count));
                Console.WriteLine(MCTIE.Max(mm=>mm.Count));
                Console.WriteLine(clas2.Average(rrr=> rrr.Count));

                Console.WriteLine(clas2.Average(rrr => rrr.ID));
                Console.WriteLine(new string('*', 50));

                Console.ReadKey();
            }
        }
    }
}
