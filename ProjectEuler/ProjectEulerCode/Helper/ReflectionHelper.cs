using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEulerCode.Helper
{
    public static class ReflectionHelper
    {
        public static string CallProblemMethod(int qNumber)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var method = typeof(Problems).GetMethod("Problem" + qNumber);
            var answer = method.Invoke(null, null);

            sw.Stop();
            Console.WriteLine("Time elapsed: {0}\n", sw.Elapsed);

            return answer.ToString();
        }

        public static string GetMethodsNumberString()
        {
            int count = typeof(Problems).GetMethods().Where(x => x.Name.StartsWith("Problem")).Count();
            return "1 to " + count;
        }
    }
}