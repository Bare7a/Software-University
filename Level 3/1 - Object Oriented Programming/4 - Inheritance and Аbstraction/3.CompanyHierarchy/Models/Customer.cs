namespace _3.Company_Hierarchy.Models
{
    using System;

    public class Customer : Person
    {
        private decimal purchaseAmmount;
        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {
            this.PurchaseAmmount = purchaseAmmount;
        }

        public decimal PurchaseAmmount {
            get { return this.purchaseAmmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Purchase ammount cannot be a negative number!");
                }
                this.purchaseAmmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "| Position: Customer";
        }
    }
}
