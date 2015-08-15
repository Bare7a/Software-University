using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _2_Employee_DAO_Class_Test
    {
        static void Main()
        {
            //---------------------------------------------------------------------------------------
            //The methods are located in ModelExtentions>Employee.cs
            //Better start with a fresh SoftUni DB since the ID might be different than 299 otherwise
            //---------------------------------------------------------------------------------------
            //Adding a new employee to the DataBase

            Employee.Add("Ivan", "Ivanov", "Marketing Manager", "Purchasing", DateTime.Now, 5000);
            Console.WriteLine("({0}) {1} {2}", Employee.FindByID(299).EmployeeID, Employee.FindByID(299).FirstName, Employee.FindByID(299).LastName);

            //Modifying the first name of the 299 employee

            Employee.Modify(299, "Gosho");
            Console.WriteLine("({0}) {1} {2}", Employee.FindByID(299).EmployeeID, Employee.FindByID(299).FirstName, Employee.FindByID(299).LastName);

            //Deleting employee with id 299
            Employee.Delete(299);
        }
    }
}
