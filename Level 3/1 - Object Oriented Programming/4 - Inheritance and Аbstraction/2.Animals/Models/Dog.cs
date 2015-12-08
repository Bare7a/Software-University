namespace _2.Animals.Models
{
    using System;

    class Dog : Animal
    {
        public Dog(string name, byte age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Dog says: Bark bark!");
        }
    }
}
