using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    /// What is the sum of the digits of the number 2^1000?
    /// </summary>
    public class Euler016 : IEulerProblem
    {
        public string Solve()
        {
            double result = 0;

            string resultString = "1";
            for (int i = 1; i <= 1000; i++)
            {
                int carry = 0;
                string newprod = "";
                for (int j = resultString.Length-1; j >= 0; j--)
                {
                    var p = int.Parse(resultString[j].ToString())*2 + carry;
                    var c = (p%10);
                    newprod = c + newprod;
                    carry = p/10;
                }          
                if( carry > 0) {newprod = carry + newprod;}
                resultString = newprod;
            }


            foreach (var c in resultString)
            {
                result += int.Parse(c.ToString());
            }

            return string.Format("Result = {0}", result);
        }


    }
}
