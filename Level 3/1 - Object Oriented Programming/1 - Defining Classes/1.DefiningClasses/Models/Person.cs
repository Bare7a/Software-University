using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Defining_Classes.Models
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Invalid Name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Invalid Age");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Invalid Email");
                }
            }
        }

        public string ToString()
        {
            string informationAboutPerson = string.Format("This is {0} who is {1} age old, email: {2}", this.Name, this.Age, this.Email?? "not specified");
            return informationAboutPerson;
        }
    }
}
