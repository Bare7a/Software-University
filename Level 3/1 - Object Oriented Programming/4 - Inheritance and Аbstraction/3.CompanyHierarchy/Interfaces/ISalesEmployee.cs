using System.Collections.Generic;
using _3.Company_Hierarchy.Models.Products;

namespace _3.Company_Hierarchy.Interfaces
{
    public interface ISalesEmployee
    {
        ICollection<Sale> Sales { get; set; }
    }
}