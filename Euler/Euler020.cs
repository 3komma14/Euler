using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler
{
    /// <summary>
    /// n! means n * (n-1)  ...  3 * 2 * 1
    /// 
    /// For example, 10! = 10 * 9  ...  3 * 2 * 1 = 3628800,
    /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    /// 
    /// Find the sum of the digits in the number 100!
    /// </summary>
    public class Euler020 : IEulerProblem
    {
        public string Solve()
        {
            double result = 0;
            BigInteger fac = 1;
            for(int i = 100; i>0; i--)
            {
                fac = BigInteger.Multiply(fac, i);
            }

            var tmp = fac.ToString();
            foreach (var c in tmp)
            {
                result += int.Parse(c.ToString());
            }

            return string.Format("Result = {0}", result);
        }

    }
}
