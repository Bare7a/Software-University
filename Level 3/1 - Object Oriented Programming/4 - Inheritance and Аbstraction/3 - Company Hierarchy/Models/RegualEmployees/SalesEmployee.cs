using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interfaces;
using _3.Company_Hierarchy.Models.Products;

namespace _3.Company_Hierarchy.Models.RegualEmployees
{
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
