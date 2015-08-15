using StudentSystem.Models;

namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystem.Data.StudentContext";
        }

        protected override void Seed(StudentSystem.Data.StudentContext context)
        {
            if(context.Students.Any()) return;
            context.Students.AddOrUpdate(new Student
            {
                Name = "Boiko Terziev",
                PhoneNumber= "359 888 888 888",
                Birthday = new DateTime(1980, 5, 5),
                RegisteredOn = new DateTime(2015, 6, 8)
            });

            context.Students.AddOrUpdate(new Student
            {
                Name = "Ivan Ivanov",
                PhoneNumber = "359 888 999 111",
                Birthday = new DateTime(1990, 3, 9),
                RegisteredOn = new DateTime(2015, 3, 9)
            });

            context.Students.AddOrUpdate(new Student
            {
                Name = "Georgi Georgiev",
                PhoneNumber = "359 222 000 555",
                Birthday = new DateTime(1984, 4, 2),
                RegisteredOn = new DateTime(2015, 8, 2)
            });

            context.Students.AddOrUpdate(new Student
            {
                Name = "Svetlin Nakov",
                PhoneNumber = "359 222 000 777",
                Birthday = new DateTime(1984, 4, 12),
                RegisteredOn = new DateTime(2015, 7, 23)
            });

            var resource1 = new Resource
            {
                Name = "C# Live Demo",
                Type = ResourceType.Video,
                Link = "www.youtube.com"
            };

            context.Resources.AddOrUpdate(resource1);


            var resource2 = new Resource
            {
                Name = "Java Doc",
                Type = ResourceType.Document,
            };

            context.Resources.AddOrUpdate(resource2);


            var course = new Course
            {
                Name = "C#",
                Description = "C# Course",
                StartDate = new DateTime(2015, 1, 1),
                EndDate = new DateTime(2015, 1, 30),
                Price = 100
            };

            course.Resources.Add(resource1);
            course.Resources.Add(resource2);
            context.Courses.AddOrUpdate(course);

            course = new Course
            {
                Name = "Java",
                Description = "Java Course",
                StartDate = new DateTime(2015, 2, 1),
                EndDate = new DateTime(2015, 2, 25),
                Price = 200
            };

            context.Courses.AddOrUpdate();
            course.Resources.Add(resource2);
            context.Courses.AddOrUpdate(course);

            context.SaveChanges();

            var student = context.Students.Find(1);
            var course1 = context.Courses.Find(1);

            context.Homeworks.AddOrUpdate(new Homework
            {
                Content = "Homework 1",
                Course = course1,
                Student = student,
                SubmittedOn = new DateTime(2015, 3, 30, 23, 59, 59),
            });

            context.SaveChanges();
        }
    }
}
