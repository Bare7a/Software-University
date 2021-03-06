﻿namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;
        
        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }
        
        public int Id { get; set; }
        
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        } 
    }
}