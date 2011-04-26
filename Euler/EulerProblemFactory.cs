using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Euler
{
    public class EulerProblemFactory
    {
        public static IEulerProblem Create(int number)
        {
            var objType = Assembly.GetExecutingAssembly().GetType(string.Format("Euler.Euler{0:D3}", number));
            return Activator.CreateInstance(objType) as IEulerProblem;
        }
    }
}
