using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _3_4_DataBase_Search_Queries
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            var departments =
                db.Departments.Where(d => d.Employees.Count > 5).OrderBy(d => d.Employees.Count).Select(d => new
                {
                    DepartmentName = d.Name,
                    MName = d.Employee.FirstName + " " + d.Employee.LastName,
                    Employees = d.Employees.Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.HireDate,
                        e.JobTitle
                    })
                        .ToList()
                })
                .ToList();
            foreach (var department in departments)
            {
                Console.WriteLine("-- {0} - Manager: {1}, Employees: {2}",
                    department.DepartmentName, department.MName, department.Employees.Count);
                //Uncomment this if you want to see all employees in the current department
                //foreach (var employee in department.Employees)
                //{
                //    Console.WriteLine(employee.FirstName+" "+employee.LastName);
                //}
            }
        }
    }
}
