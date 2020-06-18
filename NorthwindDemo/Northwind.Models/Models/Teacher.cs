using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(10)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //This will not be in the SQL Table
        [NotMapped]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
            

        public int CityId { get; set; }

        public virtual City City { get; set; }
       
    }
}
