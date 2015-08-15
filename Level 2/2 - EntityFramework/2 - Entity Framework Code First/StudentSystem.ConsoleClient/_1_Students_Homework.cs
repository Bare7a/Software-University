using System;
using System.Linq;
using StudentSystem.Data;

namespace StudentSystem.ConsoleClient
{
    class _1_Students_Homework
    {
        static void Main(string[] args)
        {
            var db = new StudentContext();
            var students = db.Students
                .Select(s => new
                {
                    s.Name,
                    Homework=s.Homeworks.Select(h=>new
                    {
                        h.Content,
                        h.Type
                    })
                });
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
                foreach (var homework in student.Homework)
                {
                    Console.WriteLine(" -- {0} - {1}",homework.Content,homework.Type);
                }
            }
        }
    }
}
