using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCode.Helper
{
    public static class ReflectionHelper
    {
        public static void CallProblemMethod(int qNumber)
        {
            var method = typeof(Problems).GetMethod("Problem" + qNumber);
            method.Invoke(null, null);
        }

        public static string GetMethodsNumberString()
        {
            int count = typeof(Problems).GetMethods().Where(x => x.Name.StartsWith("Problem")).Count();
            return "1 to " + count;
        }
    }
}