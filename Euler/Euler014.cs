using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// The following iterative sequence is defined for the set of positive integers:
    ///     n  n/2 (n is even)
    ///     n  3n + 1 (n is odd)
    /// Using the rule above and starting with 13, we generate the following sequence:
    /// 13  40  20  10  5  16  8  4  2  1
    /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    /// Which starting number, under one million, produces the longest chain?
    /// NOTE: Once the chain starts the terms are allowed to go above one million.
    /// </summary>
    public class Euler014 : IEulerProblem
    {
        private Dictionary<long, long> cache = new Dictionary<long, long>();

        public string Solve()
        {
            long result = 0;
            long maxChainLength = 0;


            for (long i = 2; i < 1000000; i++)
            {
                var chainLength = GetChainLength(i);
                //Console.WriteLine("{0}: length = {1}",i, chainLength);
                if(chainLength > maxChainLength)
                {
                    result = i;
                    maxChainLength = chainLength;
                }
            }

            return string.Format("Result = {0}", result);
        }

        private long GetChainLength(long value)
        {
            long result = 1;
            long current = value;
            while(current > 1)
            {
                current = current.IsEven() ? current/2 : 3*current + 1;
                long cachedValue;
                if(cache.TryGetValue(current, out cachedValue))
                {
                    result += cachedValue;
                    current = 1;
                }
                else
                {
                    result++;                    
                }
            }
            cache.Add(value, result);
            return result;
        }
    }
}
