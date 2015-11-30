namespace _3.Company_Hierarchy.Models
{
    public abstract class RegualEmployee : Employee
    {
        protected RegualEmployee(string firstName, string lastName, decimal salary, Department department) : base(firstName, lastName, salary, department)
        {
        }
    }
}