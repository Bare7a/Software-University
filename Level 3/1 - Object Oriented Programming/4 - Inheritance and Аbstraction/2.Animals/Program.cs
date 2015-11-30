using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Animals.Models;

namespace _2.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat ("Genderless cat",5, Gender.Other));
            cats.Add(new Cat ("Male cat",4, Gender.Male));
            cats.Add(new Cat("Female cat", 2, Gender.Female));

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Snoop Dog",44, Gender.Male));
            dogs.Add(new Dog("Spike", 10, Gender.Male));
            dogs.Add(new Dog("Kichka", 60, Gender.Female));

            List<Frog> frogs = new List<Frog>();
            frogs.Add(new Frog("Pepe", 20, Gender.Male));
            frogs.Add(new Frog("Pepinia",16, Gender.Female));

            List<Kitten> kittens = new List<Kitten>();
            kittens.Add(new Kitten("Yuno", 14));
            kittens.Add(new Kitten("Shiro", 15));

            List<Tomcat> tomcats = new List<Tomcat>();
            tomcats.Add(new Tomcat("Tom",4));
            tomcats.Add(new Tomcat("Chinchin",7));

            List<Animal> animals = new List<Animal>();
            animals.AddRange(cats);
            animals.AddRange(dogs);
            animals.AddRange(frogs);
            animals.AddRange(kittens);
            animals.AddRange(tomcats);

            int ageCount = (int) Math.Round(animals.Average(a=>a.Age));
            Console.WriteLine(ageCount);
        }
    }
}
