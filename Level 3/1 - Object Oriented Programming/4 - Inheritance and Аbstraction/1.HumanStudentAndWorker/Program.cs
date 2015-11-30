using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Human__Student_and_Worker.Models;

namespace _1.Human__Student_and_Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", "Peshev", 9999999999));
            students.Add(new Student("Gosho", "Goshov", 10000));
            students.Add(new Student("Pencho", "Penchev", 500800));
            students.Add(new Student("Dancho", "Danchev", 105000));
            students.Add(new Student("Gencho", "Genchev", 30001230));
            students.Add(new Student("Maxy", "Maxiev", 100407));
            students.Add(new Student("Micky", "Mouse", 1080310));
            students.Add(new Student("Mincho", "Minchev", 990000));
            students.Add(new Student("Ivan", "Ivanov", 1056000));
            students.Add(new Student("Mitko", "Mitkov", 1071000));
            students = students.OrderBy(s => s.FacultyNumber).ToList();

            Console.WriteLine("--- Students ----");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Pesho", "Peshov", 1200, 12));
            workers.Add(new Worker("Gosho", "Goshev", 2000, 10));
            workers.Add(new Worker("Pencho", "Penchev", 600, 8));
            workers.Add(new Worker("Dancho", "Denchev", 900, 8));
            workers.Add(new Worker("Gencho", "Ganchev", 4000, 6));
            workers.Add(new Worker("Maxy", "Maxoev", 2200, 12));
            workers.Add(new Worker("Micky", "Mice", 1200, 9));
            workers.Add(new Worker("Mincho", "Minchov", 400, 5));
            workers.Add(new Worker("Ivan", "Ivanev", 1100, 7));
            workers.Add(new Worker("Dimitar", "Mitkov", 1000, 10));
            workers = workers.OrderBy(w => w.MoneyPerHour()).ToList();

            Console.WriteLine();
            Console.WriteLine("--- Workers ----");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }

            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);
            people = people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();

            Console.WriteLine();
            Console.WriteLine("--- People ----");
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
