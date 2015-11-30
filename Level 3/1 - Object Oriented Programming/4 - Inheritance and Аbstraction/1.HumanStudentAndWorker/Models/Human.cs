using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human__Student_and_Worker.Models
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("First name must be atleast 3 characters long.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Last name must be atleast 3 characters long.");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
