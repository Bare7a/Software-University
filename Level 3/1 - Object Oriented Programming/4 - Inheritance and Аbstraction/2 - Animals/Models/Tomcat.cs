using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals.Models
{
    class Tomcat : Cat
    {
        public Tomcat(string name, byte age, Gender gender) : base(name, age, gender)
        {
            if (gender != Gender.Male)
            {
                throw new ArgumentException("Tomcat must be male!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat says: Meooooow :3");
        }
    }
}
