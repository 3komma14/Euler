using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 552 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Euler006 : IEulerProblem
    {
        public string Solve()
        {
            long result = 0;
            long sumOfSquares = 0;
            long sum = 0;

            for (int i = 1; i <= 100; i++ )
            {
                sumOfSquares += i*i;
                sum += i;
            }
            long squareOfSum = sum * sum;

            Console.WriteLine("SumOfSquares = {0}", sumOfSquares);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("SquareOfSum = {0}", squareOfSum);

            return string.Format("Result = {0}", squareOfSum - sumOfSquares);
        }


    }
}
