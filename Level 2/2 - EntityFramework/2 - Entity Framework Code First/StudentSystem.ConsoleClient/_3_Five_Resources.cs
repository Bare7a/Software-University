using System;
using System.Linq;
using StudentSystem.Data;

namespace StudentSystem.ConsoleClient
{
    class _3_Five_Resources
    {
        private static void Main(string[] args)
        {
            var db = new StudentContext();
            var courses = db.Courses
                .Where(c => c.Resources.Count >= 5)
                .OrderByDescending(c=>c.Resources.Count)
                .ThenByDescending(c=>c.StartDate)
                .Select(c=>new
                {
                    c.Name,
                    ResourcesCount=c.Resources.Count
                });
            foreach (var course in courses)
            {
                Console.WriteLine("- {0} has {1} resources", course.Name, course.ResourcesCount);
            }
        }
    }
}
