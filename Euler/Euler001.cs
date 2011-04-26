using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Euler001 : IEulerProblem
    {
        public string Solve()
        {
            var r1 = SumarizeNumber(3, 999);
            var r2 = SumarizeNumber(5, 999);
            var r3 = SumarizeNumber(15, 999);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            return string.Format("Result = {0}", (r1 + r2 - r3));
        }

        private double SumarizeNumber(double numberToSumarize, double maxValue)
        {
            var a = Math.Truncate(maxValue / numberToSumarize);
            var r = numberToSumarize * ((1 + a) * a) / 2;
            return r;
        }

        public double SumarizeNumber2(int numberToSumarize, double maxValue)
        {
            var r = 0;
            var i = numberToSumarize;
            while (i <= maxValue)
            {
                r += i;
                Console.WriteLine(r);
                i += numberToSumarize;
            }
            Console.ReadLine();
            return r;
        }
    }
}
