using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Euler010 : IEulerProblem
    {
        public string Solve()
        {
            long result = 0;

            for (long i = 1; i < 2000000; i++)
            {
                if (i.IsPrime())
                {
                    result += i;
                }
            }

            return string.Format("Result = {0}", result);
        }


    }
}
