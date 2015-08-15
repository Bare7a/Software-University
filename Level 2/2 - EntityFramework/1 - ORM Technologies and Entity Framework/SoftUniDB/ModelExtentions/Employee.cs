using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    public partial class Employee
    {
        public static void Add(string firstName, string lastName, string jobTitle, string department, DateTime hireDate, int salary)
        {
            var db = new SoftUniEntities();
            var depName = db.Departments.First(d => d.Name == department.ToString());
            var employee = new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                JobTitle = jobTitle,
                DepartmentID = depName.DepartmentID,
                HireDate = hireDate,
                Salary = salary
            };

            db.Employees.Add(employee);
            db.SaveChanges();
        }
        public static Employee FindByID(int id)
        {
            var db = new SoftUniEntities();
            Employee employee = db.Employees.Find(id);
            return employee;
        }
        public static void Modify(int id, string firstName)
        {
            var db = new SoftUniEntities();
            Employee employee = db.Employees.Find(id);
            employee.FirstName=firstName;
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var db = new SoftUniEntities();
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}
