namespace _2.Animals.Models
{
    using System;

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
