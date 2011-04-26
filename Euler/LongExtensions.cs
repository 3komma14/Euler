using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public static class LongExtensions
    {
        public static bool IsPrime(this long value)
        {
            // Throw out impossibles
            if (value < 2)
            {
                return false;
            }

            // Don't need to test above the square root of a number
            var squareRootOfValue = (int)Math.Sqrt(value);
            for (var i = 2; i <= squareRootOfValue; i++)
            {
                // If remainder is 0, number is not prime
                if (value % i == 0)
                {
                    // return false
                    return false;
                }
            }

            // If all conditions are met, return true
            return true;
        }

        public static bool IsOdd(this long value)
        {
            return ((value & 1) == 1);
        }

        public static bool IsEven(this long value)
        {
            return ((value & 1) == 0);
        }
    }
}
