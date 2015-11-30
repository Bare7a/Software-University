using System.Collections.Generic;
using _3.Company_Hierarchy.Models.Products;

namespace _3.Company_Hierarchy.Interfaces
{
    public interface IDeveloper
    {
        ICollection<Project> Projects { get; set; }
        void CloseProject(Project project);
    }
}