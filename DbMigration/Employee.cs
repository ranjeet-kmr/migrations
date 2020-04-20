using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbMigration
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string FirstLastName { get; set; }
        public string Gender { get; set; }

        public int Age { get; set; }

        public bool IsActive { get; set; }
        public string Salary { get; set; }
        public Department Department { get; set; }
    }
}