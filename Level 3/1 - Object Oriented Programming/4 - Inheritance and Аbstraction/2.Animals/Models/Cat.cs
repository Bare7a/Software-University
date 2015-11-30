using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals.Models
{
    class Cat : Animal
    {
        public Cat(string name, byte age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cat says: Meooww");
        }
    }
}
