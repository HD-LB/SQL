using Northwind.Data;
using Northwind.Data.Models;
using Northwind.DataModels;
using Northwind.DataModels.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.App
{
    class Program
    {
        static void Main()
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NorthwindDbContext, Configuration>());


            ////Creating a DB
            //using (var dbContext = new NorthwindDbContext())
            //{
            //    dbContext.Database.CreateIfNotExists();
            //}

            ////Adding Content
            //var dbContext = new NorthwindDbContext();

            //var newCountry = new Country()
            //{
            //    Name = "Bulgaria"
            //};

            //dbContext.Countries.Add(newCountry);
            //dbContext.SaveChanges();


            ////Searching per Id
            //var country = dbContext.Countries.FirstOrDefault(c => c.Id == 1);

            //Console.WriteLine(country.Name);

            //dbContext.Countries.Add(new Country()
            //{
            //    Name = "Albania"
            //});
            //dbContext.SaveChanges();           
            

        }
    }
}
