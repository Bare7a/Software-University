namespace _3.Company_Hierarchy.Interfaces
{
    using System.Collections.Generic;
    using Models.Products;

    public interface IDeveloper
    {
        ICollection<Project> Projects { get; set; }
        void CloseProject(Project project);
    }
}