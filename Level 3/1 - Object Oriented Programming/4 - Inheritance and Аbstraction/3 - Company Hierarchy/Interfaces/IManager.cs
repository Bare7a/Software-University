using System.Collections.Generic;
using _3.Company_Hierarchy.Models;

namespace _3.Company_Hierarchy.Interfaces
{
    public interface IManager
    {
        ICollection<RegualEmployee> RegualEmployees { get; set; }
    }
}