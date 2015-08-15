using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using StudentSystem.Data;

namespace StudentSystem.ConsoleClient
{
    class _4_Courses_On_A_Given_Date
    {
        private static void Main()
        {
            var db = new StudentContext();
            var courses = db.Courses
                .Where(c => c.StartDate == new DateTime(2015, 2, 1))
                .OrderByDescending(c => c.Students.Count)
                .ThenByDescending(c => EntityFunctions.DiffDays(c.StartDate, c.EndDate))
                .Select(c => new
                {
                    c.Name,
                    StudentsCount = c.Students.Count,
                    Duration = EntityFunctions.DiffDays(c.StartDate,c.EndDate)
                });
            foreach (var course in courses)
            {
                Console.WriteLine("- {0} has {1} students and its duration is {2} days",course.Name, course.StudentsCount,course.Duration);
            }
        }
    }
}
