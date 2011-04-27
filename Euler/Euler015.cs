using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Starting in the top left corner of a 22 grid, there are 6 routes (without backtracking) to the bottom right corner.
    /// 
    /// How many routes are there through a 2020 grid?
    /// </summary>
    public class Euler015 : IEulerProblem
    {
        public string Solve()
        {
            double result = 0;
            long n = 20;
            result = (2 * n).Factorial() / (n.Factorial() * n.Factorial());

            return string.Format("Result = {0}", result);
        }

    }
}
