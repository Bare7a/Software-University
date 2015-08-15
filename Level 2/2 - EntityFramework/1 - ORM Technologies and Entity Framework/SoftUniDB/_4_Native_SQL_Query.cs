using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SoftUniDB
{
    class _4_Native_SQL_Query
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            var totalCount = db.Employees.Count();
            var sw = new Stopwatch();
            //Time 00:00:00
            NativeQuery();
            Console.WriteLine("Native: {0}",sw.Elapsed);
            sw.Restart();
            //Time 00:00:001661098
            LinqQuery();
            Console.WriteLine("Linq: {0}", sw.Elapsed);
        }

        public static void NativeQuery()
        {
            var db = new SoftUniEntities();
            int count = 0;
            var query = "USE SoftUni SELECT DISTINCT e.FirstName FROM Employees e JOIN EmployeesProjects ep ON e.EmployeeID=ep.EmployeeID JOIN Projects p ON ep.ProjectID=p.ProjectID WHERE YEAR(p.StartDate)=2003 ORDER BY e.FirstName";
            var employees = db.Database.SqlQuery<string>(String.Format(query)).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                count++;
            }
            Console.WriteLine(count);
        }

        public static void LinqQuery()
        {
            var db = new SoftUniEntities();
            int count = 0;
            var employees = db.Employees
                .Where(e => e.Projects.Any(p=>p.StartDate.Year==2003))
                .OrderBy(e => e.FirstName)
                .Select(e => e.FirstName)
                .Distinct();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
