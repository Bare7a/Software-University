namespace _3.Company_Hierarchy.Models.RegualEmployees
{
    using System.Collections.Generic;
    using Interfaces;
    using Products;

    class SalesEmployee : RegualEmployee,ISalesEmployee
    {
        private ICollection<Sale> sales { get; set; }

        public SalesEmployee( string firstName, string lastName, decimal salary) : base(firstName, lastName, salary, Department.Sales)
        {
            this.sales = new HashSet<Sale>();
        }

        public ICollection<Sale> Sales
        {
            get { return this.sales; }
            set { this.sales = sales; }
        }
        public override string ToString()
        {
            return base.ToString() + ", Position: Sales Employee";
        }
    }
}
