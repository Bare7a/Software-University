namespace _3.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;
    using Models.Products;

    public interface ISalesEmployee
    {
        ICollection<Sale> Sales { get; set; }
    }
}