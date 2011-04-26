using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 x 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Euler004 : IEulerProblem
    {
        public string Solve()
        {
            long result = 0;

            for (var n = 999; n >= 100; n-- )
            {
                for(var m = 999; m >= 100; m--)
                {
                    var val = (n*m).ToString();
                    if(val.Reverse().SequenceEqual(val.AsEnumerable()))
                    {
                        result = Math.Max(long.Parse(val), result);
                        Console.WriteLine("{0} x {1} = {2}", n, m, val);
                        //break;
                    }
                }
            }

            return string.Format("Result = {0}", result);
        }

    }
}
