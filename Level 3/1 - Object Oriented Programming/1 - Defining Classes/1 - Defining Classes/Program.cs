using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1___Defining_Classes.Models;

namespace _1___Defining_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person gosho = new Person("Gosho", 20);
            Person pesho = new Person("Pesho", 20, "pesho@peshkata.com");
            Console.WriteLine(gosho.ToString());
            Console.WriteLine(pesho.ToString());
        }
    }
}
