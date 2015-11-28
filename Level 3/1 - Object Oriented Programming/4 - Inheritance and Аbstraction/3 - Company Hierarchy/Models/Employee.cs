using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interfaces;

namespace _3.Company_Hierarchy.Models
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;
        protected Employee(string firstName, string lastName, decimal salary, Department department) : base(firstName, lastName)
        {
            this.Salary = salary;
            this.department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (salary < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be a negative number!");
                }
                this.salary = value;
            }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"| Department: {this.Department}, Salary: {this.Salary}";
        }
    }
}
