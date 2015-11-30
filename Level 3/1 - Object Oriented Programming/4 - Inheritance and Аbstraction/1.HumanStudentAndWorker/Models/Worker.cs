using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human__Student_and_Worker.Models
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private byte workHoursPerDay;
        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be a negative number!");
                }
                this.weekSalary = value;
            }
        }

        public byte WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be between 0 and 24 hours.");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / this.workHoursPerDay;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Money Per Hour: {Math.Round(this.MoneyPerHour(),2)}, Week Salary: {Math.Round(this.WeekSalary,2)}, Work Hours Per Day {this.WorkHoursPerDay}";
        }
    }
}
