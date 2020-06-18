//https://www.youtube.com/watch?v=GhPnWOfvTAc&list=PLF4lVL1sPDSm5uoRFcaXb_6gCz4okfSiY&index=12

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EfWithSqlServer.Data;

namespace EfWithSqlServer
{
    class EfWithSqlMain
    {
        static void Main()
        {
            //var dbContex = new NORTHWNDEntities();

            //var newCategory = new Category()
            //{
            //    CategoryName = "",
            //    Description = "",
            //    Picture = new byte[5]
            //};

            //dbContex.Categories.Add(newCategory);
            //dbContex.SaveChanges();

            //var category = dbContex.Categories.Find(9);
            //category.CategoryName = "NEW CATEGORY";

            //dbContex.SaveChanges();

            //var remove = dbContex.Categories.Find(9);
            //dbContex.Categories.Remove(remove);

            //dbContex.SaveChanges();


            //var categories = dbContex.Categories;
            //foreach (var cat in categories)
            //{
            //    Console.WriteLine(cat.CategoryName);
            //}

            //var categories = dbContex.Database.SqlQuery<Category>("SELECT * FROM Categories");

            //foreach(var category in categories)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            //var customers = dbContex.Customers.Where(c => c.City == "London").Select(c => c.Phone);

            //Console.WriteLine(customers);

            //dbContex.Customers.Where(c => c.City == "London").Select(c => c.Phone).ToList().ForEach(Console.WriteLine);




            using (var writer = new StreamWriter("db-logs.txt"))
            {
                var dbContex = new NORTHWNDEntities();

                dbContex.Database.Log = writer.WriteLine;

                //var query = dbContex.Customers.Where(c => c.City == "London").OrderBy(c => c.Phone).SelectMany(c => c.Orders).ToList();


                ////Deleting a product in a particular category, 
                //var cat = dbContex.Categories.Find(80);
                //foreach (var product in cat.Products.ToList())
                //{
                //    cat.Products.Remove(product); //i.e. the conection to the DB is broken
                //    dbContex.Products.Remove(product); //deliting from the DB
                //}


                //Adding 
                var product = GetProductById(6);
                var entry = dbContex.Entry(product);

                product.ProductName += "Updated";
                dbContex.SaveChanges();

                Console.WriteLine(product.ProductName);

            }

                
        }

        //Method for Looking for a Product in the DB
        private static Product GetProductById(int id)
        {
            var dbContest = new NORTHWNDEntities();
            using (dbContest)
            {
                return dbContest.Products.Find(id);
            }
        }
    }
}
