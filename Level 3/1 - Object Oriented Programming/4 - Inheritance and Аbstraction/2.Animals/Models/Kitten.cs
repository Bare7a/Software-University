using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals.Models
{
    class Kitten : Cat
    {
        public Kitten(string name, byte age) : base(name, age, Gender.Female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitten says: Meooooow =^.^=");
        }
    }
}
