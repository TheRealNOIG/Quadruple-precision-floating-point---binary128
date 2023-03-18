using System.Numerics;

namespace BigInt.Math
{
    public class Quad
    {
        private bool sign;         // 1 bit (true = negative, false = positive)
        private ushort exponent;   // 15 bits
        private BigInteger mantissa; // 112 bits

        public Quad(bool sign, ushort exponent, BigInteger mantissa)
        {
            this.sign = sign;
            this.exponent = exponent;
            this.mantissa = mantissa;
        }

        // TODO Implement additional methods for arithmetic operations, comparisons, and conversions
    }
}