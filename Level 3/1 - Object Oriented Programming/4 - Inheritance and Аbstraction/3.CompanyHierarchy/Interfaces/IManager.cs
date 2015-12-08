namespace _3.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IManager
    {
        ICollection<RegualEmployee> RegualEmployees { get; set; }
    }
}