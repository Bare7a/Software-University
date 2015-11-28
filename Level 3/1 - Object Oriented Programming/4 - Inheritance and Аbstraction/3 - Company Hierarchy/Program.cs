using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Models;
using _3.Company_Hierarchy.Models.RegualEmployees;

namespace _3.Company_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Manager("Angel", "Angelov", 2000, Department.Accounting));
            employees.Add(new Manager("Blagoi", "Blagoev", 1500, Department.Marketing));
            employees.Add(new Manager("Borislav", "Borislavov", 1600, Department.Sales));
            employees.Add(new SalesEmployee("Ivan", "Ivanov", 900));
            employees.Add(new SalesEmployee("Georgi", "Georgiev", 700));
            employees.Add(new SalesEmployee("Yordan", "Yordanov", 500));
            employees.Add(new Developer("Pencho", "Penchev", 1900));
            employees.Add(new Developer("Vladi", "Vladimirov", 1600));
            employees.Add(new Developer("Aatrox", "Alistar", 1500));

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
