namespace _3.Company_Hierarchy.Interfaces
{
    using Models;

    public interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
