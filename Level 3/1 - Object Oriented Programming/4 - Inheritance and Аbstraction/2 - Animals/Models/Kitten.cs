using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals.Models
{
    class Kitten : Cat
    {
        public Kitten(string name, byte age, Gender gender) : base(name, age, gender)
        {
            if (gender != Gender.Female)
            {
                throw new ArgumentException("Kitten can only be female!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitten says: Meooooow =^.^=");
        }
    }
}
