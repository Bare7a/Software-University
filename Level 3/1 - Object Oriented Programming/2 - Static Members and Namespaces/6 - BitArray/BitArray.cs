namespace _06.BitArray
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class BitArray
    {
        private readonly int[] num;

        public BitArray(int numberOfBits)
        {
            if (numberOfBits < 1 || numberOfBits > 100000)
            {
                throw new ArgumentOutOfRangeException("Number of bits should be in range [1..100000].");
            }

            this.num = new int[numberOfBits];
        }

        public int this[int index]
        {
            set
            {
                if (index < 0 || index >= this.num.Length)
                {
                    throw new ArgumentOutOfRangeException($"Bit position should be in range [0..{this.num.Length - 1}].");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Bit value should be either 1 or 0.");
                }

                this.SetBitAtPos(index, value);
            }
        }

        public override string ToString()
        {
            return this.BinaryToDecimal();
        }

        private void SetBitAtPos(int pos, int bit)
        {
            this.num[pos] = bit;
        }

        private string BinaryToDecimal()
        {
            var decimalNum = new BigInteger(0);
            for (var i = 0; i < this.num.Length; i++)
            {
                decimalNum += int.Parse(this.num[i].ToString()) * (BigInteger)Math.Pow(2, i);
            }

            return decimalNum.ToString();
        }
    }
}