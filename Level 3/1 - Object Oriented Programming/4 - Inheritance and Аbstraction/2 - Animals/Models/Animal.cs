using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Animals.Interfaces;

namespace _2.Animals.Models
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private byte age;
        private Gender gender;

        protected Animal(string name, byte age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                if (value.Length < 3 && value.Length > 1000)
                {
                    throw new ArgumentOutOfRangeException("Name must be between 3 and 1000 characters long.");
                }
                this.name = value;
            }
        }

        public byte Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100");
                }
                this.age = value;
            }
        }

        public abstract void ProduceSound();
    }
}
