using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals.Models
{
    class Tomcat : Cat
    {
        public Tomcat(string name, byte age) : base(name, age, Gender.Male)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat says: Meooooow :3");
        }
    }
}
