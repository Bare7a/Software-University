using System;

namespace _3.Company_Hierarchy.Models.Products
{
    public class Sale
    {
        private string name;
        private DateTime date;
        private decimal price;

        public Sale(string name, DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                if (value.Length < 3 || value.Length > 1000)
                {
                    throw new ArgumentOutOfRangeException("Name must be between 3 and 1000 characters long!");
                }
                this.name = value;
            }
        }

        public DateTime Date
        {
            get { return date; }
            set { this.date = value; }
        }

        public decimal Price {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number!");
                }
                this.price = value;
            }
        }
    }
}
