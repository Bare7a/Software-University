using System;
using System.Linq;
using StudentSystem.Data;

namespace StudentSystem.ConsoleClient
{
    class _2_Courses_Resources
    {
        private static void Main(string[] args)
        {
            var db = new StudentContext();
            var courses = db.Courses
                .OrderBy(c=>c.StartDate).ThenByDescending(c=>c.EndDate)
                .Select(c => new
                {
                    c.Name,
                    c.Description,
                    c.Resources
                });
            foreach (var course in courses)
            {
                Console.WriteLine("-- {0} - {1}",course.Name,course.Description);
                foreach (var resource in course.Resources)
                {
                    Console.WriteLine("{0} {1} - {2} ",resource.Name,resource.Type,resource.Id);
                }
            }
        }
    }
}
