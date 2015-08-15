using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _3_3_DataBase_Search_Queries
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            var employee = db.Employees
                .Where(e => e.EmployeeID == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.Projects.OrderBy(p=>p.Name)
                });
            foreach (var emp in employee)
            {
                Console.WriteLine("{0} {1} - {2}",emp.FirstName,emp.LastName,emp.JobTitle);
                foreach(var projects in emp.Projects)
                {
                    Console.WriteLine(projects.Name);
                }
            }
        }
    }
}
