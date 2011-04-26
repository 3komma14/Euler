using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Euler005 : IEulerProblem
    {
        public string Solve()
        {
            long result = 20;

            while(NotDivisable(result))
            {
                result += 20;
            }

            return string.Format("Result = {0}", result);
        }

        private bool NotDivisable(long result)
        {
            for(int i = 2; i<=20;i++)
            {
                if ((result%i) != 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
