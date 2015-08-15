using System;
using System.Linq;
using StudentSystem.Data;

namespace StudentSystem.ConsoleClient
{
    class _5_Students_Number_Of_Courses
    {
        private static void Main()
        {
            var db = new StudentContext();
            var students = db.Students
                .OrderByDescending(s => s.Courses.Sum(c => c.Price))
                .ThenByDescending(s=>s.Courses.Count)
                .ThenBy(s=>s.Name)
                .Select(s => new
                {
                    s.Name,
                    CoursesCount=s.Courses.Count,
                    AvaragePrice=s.Courses.Average(c=>c.Price),
                    TotalPrice=s.Courses.Sum(c=>c.Price)
                });
            foreach (var student in students)
            {
                Console.WriteLine("{0} is in {1} the money he spend on those courses is {2} and the total value is {3}", student.Name, student.AvaragePrice, student.TotalPrice);
            }
        }
    }
}
