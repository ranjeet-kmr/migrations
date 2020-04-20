using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migrations
{
    class output
    {
        static void Main()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            Console.WriteLine(db.Departments.ToList());
            Console.ReadLine();
        }
    }
}
