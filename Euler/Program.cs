using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = EulerProblemFactory.Create(20);

            var start = DateTime.Now;
            Console.WriteLine(p.Solve());
            var end = DateTime.Now;

            Console.WriteLine("\n----------");
            Console.WriteLine("Time elapsed: {0}", end.Subtract(start));
            Console.ReadLine();
        }
    }
}
