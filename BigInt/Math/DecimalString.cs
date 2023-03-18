
using System.Text.RegularExpressions;

namespace BigInt.Math
{
    public class DecimalString
    {
        public bool Sign { get; set; }
        public string IntegerPart { get; set; }
        public string FractionalPart { get; set; }


        public override string ToString()
        {
            return $"Sign: {(Sign ? "-" : "+")}, Integer Part: {IntegerPart}, Fractional Part: {FractionalPart}";
        }

        public static DecimalString ParseDecimalString(string input)
        {
            // Validate the input format 
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string is null or empty.");
            }
            if (!Regex.IsMatch(input, @"^[-+]?(\d+(\.\d*)?|\.\d+)$"))
            {
                throw new ArgumentException("Invalid input format. The input must be a valid decimal number.");
            }

            DecimalString result = new();

            // Check and store the sign
            int startIndex = 0;
            if (input[0] == '-')
            {
                result.Sign = true;
                startIndex = 1;
            }
            else
            {
                result.Sign = false;
                if (input[0] == '+')
                {
                    startIndex = 1;
                }
            }

            // Find the position of the decimal point, if any
            int decimalPointIndex = input.IndexOf('.', startIndex);

            // Store the integer and fractional parts
            if (decimalPointIndex == -1)
            {
                result.IntegerPart = input.Substring(startIndex);
                result.FractionalPart = string.Empty;
            }
            else
            {
                result.IntegerPart = input.Substring(startIndex, decimalPointIndex - startIndex);
                result.FractionalPart = input.Substring(decimalPointIndex + 1);
            }

            return result;
        }
    }

}
