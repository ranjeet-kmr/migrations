using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using migrations;

namespace DbMigration
{
    public class DataRepo
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            return db.Departments.ToList();
        }
        
       
    }

}