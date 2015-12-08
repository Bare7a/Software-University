namespace _2.Animals.Models
{
    using System;

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
