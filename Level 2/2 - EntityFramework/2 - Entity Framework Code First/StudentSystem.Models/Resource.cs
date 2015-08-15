namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Resource
    {

        private ICollection<License> licenses;

        public Resource()
        {
            this.licenses = new HashSet<License>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public ResourceType Type { get; set; }

        public string Link { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<License> License
        {
            get { return this.licenses; }
            set { this.licenses = value; }
        }
    }
}