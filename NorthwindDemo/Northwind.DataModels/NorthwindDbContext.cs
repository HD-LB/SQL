using Northwind.Data.Models;
using Northwind.DataModels.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext()
            :base("NorthwindDb")
        {
           
        }

        public virtual IDbSet<City> Cities { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Teacher> Teachers { get; set; }
    }
}
