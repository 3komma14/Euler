using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    public class Euler007 : IEulerProblem
    {
        public string Solve()
        {
            var index = 10001;
            long result = GetPrimes().ElementAt(index-1); // zero based index
            return string.Format("Result = {0}", result);
        }

        private IEnumerable<long> GetPrimes()
        {
            long value = 0;
            while(value <= long.MaxValue)
            {
                if(value.IsPrime())
                {
                    yield return value;
                }
                value++;
            }
        }

    }
}
