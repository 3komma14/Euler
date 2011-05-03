using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler
{
    /// <summary>
    /// You are given the following information, but you may prefer to do some research for yourself.
    /// 
    /// 1 Jan 1900 was a Monday.
    /// Thirty days has September,
    /// April, June and November.
    /// All the rest have thirty-one,
    /// Saving February alone,
    /// Which has twenty-eight, rain or shine.
    /// And on leap years, twenty-nine.
    /// A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    /// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    /// </summary>
    public class Euler019 : IEulerProblem
    {
        public string Solve()
        {
            double result = 0;

            var date = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);
            while(date <= endDate)
            {
                if(date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(date.ToShortDateString());
                    result++;
                }
                date = date.AddMonths(1);
            }
 

            return string.Format("Result = {0}", result);
        }

    }
}
