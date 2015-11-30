using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human__Student_and_Worker.Models
{
    public class Student : Human
    {
        private long facultyNumber;
        public Student(string firstName, string lastName, long facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public long FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Faculty number cannot be negative!");
                }
                if (value <= 9999 || value > 9999999999)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must be between 5 to 10 digits long!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " | FN: " + this.FacultyNumber;
        }
    }
}
