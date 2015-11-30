using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interfaces;

namespace _3.Company_Hierarchy.Models
{
    public abstract class Person : IPerson
    {
        private static int newId = 0;
        private int id;
        private string firstName;
        private string lastName;

        protected Person(string firstName, string lastName)
        {
            this.id = Person.newId++;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
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
