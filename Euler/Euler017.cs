using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Euler
{
    /// <summary>
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used? 
    /// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
    /// </summary>
    public class Euler017 : IEulerProblem
    {
        public string Solve()
        {
            double result = 0;

            for (int i = 1; i <= 1000; i++ )
            {
                var words = GetNumberAsWord(i.ToString());
                Console.WriteLine("{0} = {1}", words, words.Length);
                result += words.Trim().Length;
            }

                return string.Format("Result = {0}", result);
        }

        public string GetNumberAsWord(string value)
        {
            if (value.Length == 1)
            {
                if (value == "0") return "";
                if (value == "1") return "One";
                if (value == "2") return "Two";
                if (value == "3") return "Three";
                if (value == "4") return "Four";
                if (value == "5") return "Five";
                if (value == "6") return "Six";
                if (value == "7") return "Seven";
                if (value == "8") return "Eight";
                if (value == "9") return "Nine";
            }

            if (value.Length == 2)
            {
                if (value == "10") return "Ten";
                if (value == "11") return "Eleven";
                if (value == "12") return "Twelve";
                if (value == "13") return "Thirteen";
                if (value == "14") return "Fourteen";
                if (value == "15") return "Fifteen";
                if (value == "16") return "Sixteen";
                if (value == "17") return "Seventeen";
                if (value == "18") return "Eighteen";
                if (value == "19") return "Nineteen";
                else
                {
                    if (value[0] == '2') return "Twenty" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '3') return "Thirty" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '4') return "Forty" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '5') return "Fifty" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '6') return "Sixty" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '7') return "Seventy" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '8') return "Eighty" + GetNumberAsWord(value[1].ToString());
                    if (value[0] == '9') return "Ninety" + GetNumberAsWord(value[1].ToString());
                }
            }

            if(value.Length == 3)
            {
                var buf = GetNumberAsWord(value[0].ToString());
                if (!string.IsNullOrEmpty(buf)) buf += "Hundred";
                var reminder = GetNumberAsWord(value.Substring(1));
                if (!string.IsNullOrEmpty(reminder)) buf += "And" + reminder;
                return buf;
            }

            if (value.Length == 4)
            {
                return GetNumberAsWord(value[0].ToString()) + "Thousand" + GetNumberAsWord(value.Substring(1));
            }

            return GetNumberAsWord(value.Substring(1));
        }


    }
}
