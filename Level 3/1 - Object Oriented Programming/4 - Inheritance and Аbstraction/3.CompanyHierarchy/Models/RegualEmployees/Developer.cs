namespace _3.Company_Hierarchy.Models.RegualEmployees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Products;

    public class Developer : RegualEmployee, IDeveloper
    {
        private ICollection<Project> projects { get; set; }

        public Developer(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary, Department.Production)
        {
            this.projects = new HashSet<Project>();
        }

        public ICollection<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        public void CloseProject(Project project)
        {
            if (this.Projects.All(p => p != project))
            {
                throw new AccessViolationException("You cannot close this project because you aren't part of it!");
            }
            project.State = State.Close;
        }

        public override string ToString()
        {
            return base.ToString() + ", Position: Developer";
        }
    }
}
