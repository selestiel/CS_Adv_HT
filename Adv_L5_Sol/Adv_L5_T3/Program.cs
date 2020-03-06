using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Adv_L5_T3.Model;


namespace Adv_L5_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ShopContext>());
            using (ShopContext db = new ShopContext())
            {
                Product p1 = new Product { productID = 1, productName = "Hleb", ProductType = "Hleb" };
                Product p2 = new Product { productID = 2, productName = "Baton", ProductType = "Hleb" };
                Product p3 = new Product { productID = 3, productName = "Moloko", ProductType = "Molochka" };
                Product p4 = new Product { productID = 4, productName = "Choko", ProductType = "Choko" };
                Shop s1 = new Shop { shopID = 1, shopName = "Brass"};
                Shop s2 = new Shop { shopID = 2, shopName = "Blue" };
                Shop s3 = new Shop { shopID = 3, shopName = "Gotic" };
                s1.Product = new List<Product> { p1, p2, p3 };
                s2.Product = new List<Product> { p2, p3, p4 };
                s3.Product = new List<Product> { p1, p2, p3, p4 };
                db.shops.AddRange(new List<Shop> { s1, s2, s3 });
                db.products.AddRange(new List<Product> { p1, p2, p3, p4 });
                db.SaveChanges();

                var products = db.products.ToList();

                foreach (var item in products)
                {
                    Console.WriteLine(@"{0, -15} {1, -15} {2, -15} {3, -15}", item.productID, item.productName, item.ProductType, item.shop != null ? item.shop.shopName : "No shop");
                }
                Console.WriteLine(new string('*', 20));
                Console.ReadKey();

                var shops = db.shops.ToList();

                foreach (var item in shops)
                {
                    Console.WriteLine(@"{0,-15} {1,-15}", item.shopID, item.shopName);

                    if (item.Product == null) continue;

                    foreach (var itemp in item.Product)
                    {
                        Console.WriteLine(@"{0,-15}  {1,-15}  {2,-15}", itemp.productID, itemp.productName, itemp.ProductType);
                    }

                    Console.WriteLine(new string('*', 20));
                }

                Console.ReadKey();
            }
        }
    }
}
