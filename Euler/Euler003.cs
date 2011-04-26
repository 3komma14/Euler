using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Euler003 : IEulerProblem
    {
        public string Solve()
        {
            long result = 0;
            long composite = 600851475143;
            long sqrtComposite = (long)Math.Sqrt(composite);
            for (var i = sqrtComposite; i > 0; i--)
            {
                Console.WriteLine("{0} : {1}", i, (composite % i));
                if((composite % i) == 0)
                {
                    if(i.IsPrime())
                    {
                        result = i;
                        break;
                    }
                }
            }
            return string.Format("Result = {0}", result);
        }

    }
}
