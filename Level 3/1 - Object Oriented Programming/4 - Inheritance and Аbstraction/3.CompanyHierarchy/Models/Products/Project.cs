using System;

namespace _3.Company_Hierarchy.Models.Products
{
    public class Project
    {
        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string name, DateTime startDate, string details, State state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                if (value.Length < 3 || value.Length > 1000)
                {
                    throw new ArgumentOutOfRangeException("Name must be between 3 and 1000 characters long!");
                }
                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Details cannot be null!");
                }
                if (value.Length < 3 || value.Length > 1000)
                {
                    throw new ArgumentOutOfRangeException("Details must be between 3 and 1000 characters long!");
                }
                this.details = value;
            }
        }
        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }
    }
}
