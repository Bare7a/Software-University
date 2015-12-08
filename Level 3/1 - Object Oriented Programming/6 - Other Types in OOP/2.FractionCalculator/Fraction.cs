namespace _2.Fraction_Calculator
{
    using System;
    
    public struct Fraction
    {
        private long numerator { get; set; }
        private long denominator { get; set; }

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }


        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value < -9223372036854775807 || value > 9223372036854775806)
                {
                    throw new ArgumentOutOfRangeException("Numerator must be between 9223372036854775807 and 9223372036854775806");
                }
                this.numerator = value;
            }
        }
        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value < -9223372036854775807 || value > 9223372036854775806 || value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominator must be between 9223372036854775807 and 9223372036854775806 excluding 0");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            long numer = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            long denom = f1.Denominator * f2.Denominator;

            return new Fraction(numer, denom);
        }

        public override string ToString()
        {
            return ((double)Numerator / Denominator).ToString();
        }
    }
}
