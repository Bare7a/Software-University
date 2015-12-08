namespace _3.Company_Hierarchy.Models
{
    using System;
    using Interfaces;

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
            return base.ToString() + String.Format("| Department: {0}, Salary: {1}", this.Department, this.Salary);
        }
    }
}
