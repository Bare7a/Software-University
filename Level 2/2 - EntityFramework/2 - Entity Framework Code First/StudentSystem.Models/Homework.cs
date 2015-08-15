namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations; 
    public class Homework
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public ContentType Type { get; set; }

        public DateTime SubmittedOn { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
