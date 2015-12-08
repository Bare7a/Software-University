namespace _2.Animals.Models
{
    using System;

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
