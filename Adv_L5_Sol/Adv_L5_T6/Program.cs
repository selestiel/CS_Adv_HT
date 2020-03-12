using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Adv_L5_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BikeDBContext>());


            using (BikeDBContext db = new BikeDBContext())
            {
                BikeType T1 = new BikeType { TypeName = "HighWay" };
                BikeType T2 = new BikeType { TypeName = "Mountain" };
                BikeType T3 = new BikeType { TypeName = "Sport" };
                BikeType T4 = new BikeType { TypeName = "Classic" };

                Bike B1 = new Bike { bikeName = "Race", bikeCount = 9, bikeType = { T1, T2 } };
                Bike B2 = new Bike { bikeName = "Adventure", bikeCount = 19, bikeType = { T2, T3, T4 } };
                Bike B3 = new Bike { bikeName = "Galaxy", bikeCount = 39, bikeType = { T1, T2, T3, T4 } };
                Bike B4 = new Bike { bikeName = "Chrono", bikeCount = 3, bikeType = { T3, T4 } };


                db.Bikes.AddRange(new List<Bike> { B1, B2, B3, B4 });
                db.SaveChanges();
                var bike1 = db.Bikes.ToList();
                BikeType T5 = new BikeType { TypeName = "US" };
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(value: db.Bikes.Include(dbs=>dbs.bikeType));
                Console.WriteLine(new string('-',20));;
                var bikeSSS = bike1.Select(sel => sel.bikeName);

                Console.WriteLine(bikeSSS);

                Console.WriteLine(new string('-', 30));
                Console.WriteLine(db.Bikes.Find(1));

                Console.WriteLine(new string('-', 30));
                Console.WriteLine(new string('*', 30));

                db.SaveChanges();

                foreach (var item in bike1)
                {
                    Console.WriteLine(@"BikeID: {0}      BikeName: {1}        BikeCount: {2}"
                    , item.bikeID, item.bikeName, item.bikeCount);

                    if (item.bikeType == null) continue;

                    foreach (var itemt in item.bikeType)
                    {
                        Console.WriteLine(@"TypeID: {0}      TypeName: {1}", itemt.TypeID, itemt.TypeName);
                    }

                    Console.WriteLine(new string('-', 30));
                }
                Console.WriteLine(new string('*',30));
                Console.ReadKey();

            }
        }
    }
}
