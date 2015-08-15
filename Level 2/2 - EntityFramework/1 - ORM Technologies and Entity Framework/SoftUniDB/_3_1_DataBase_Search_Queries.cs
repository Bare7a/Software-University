using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _3_1_DataBase_Search_Queries
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            var employees = db.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003))
                .Select(e => new 
                    {
                        e.FirstName,
                        e.LastName,
                        Projects = e.Projects.Where(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003),
                        MFirstName = e.Employee1.FirstName,
                        MLastName = e.Employee1.LastName
                    });
            foreach(var employee in employees)
            {
                Console.WriteLine("-- Employee: {0} {1} || Manager: {2} {3}", employee.FirstName, employee.LastName,employee.MFirstName,employee.MLastName);
                foreach(var project in employee.Projects)
                {
                    Console.WriteLine("* {0} {1} - {2}", project.Name, project.StartDate, project.EndDate);
                }
                Console.WriteLine();
            }
        }
    }
}
