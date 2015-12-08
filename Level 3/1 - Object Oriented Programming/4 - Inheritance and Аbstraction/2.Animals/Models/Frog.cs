namespace _2.Animals.Models
{
    using System;

    class Frog : Animal
    {
        public Frog(string name, byte age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Frog says: REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
        }
    }
}
