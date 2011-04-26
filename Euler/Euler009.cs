using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
    /// a2 + b2 = c2
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class Euler009 : IEulerProblem
    {
        public string Solve()
        {
            double result = 0;

            for(long a=1; a<500; a++)
            {
                for(long b=a+1; b<500; b++)
                {
                    var c = Math.Sqrt(a * a + b * b);
                    if((a + b + c) == 1000)
                    {
                        result = a*b*c;
                        Console.WriteLine(string.Format("{0},{1},{2}", a, b, c));
                        break;
                    }
                }
                if(result > 0)
                {
                    break;
                }
            }

            return string.Format("Result = {0}", result);
        }


    }
}
