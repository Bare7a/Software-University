

namespace _3.Company_Hierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;

    class Manager : Employee, IManager
    {
        private ICollection<RegualEmployee> regualEmployees { get; set; }

        public Manager(string firstName, string lastName, decimal salary, Department department) : base(firstName, lastName, salary, department)
        {
            this.regualEmployees = new HashSet<RegualEmployee>();
        }

        public ICollection<RegualEmployee> RegualEmployees
        {
            get { return this.regualEmployees; }
            set { this.regualEmployees = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", Position: Manager";
        }
    }
}
