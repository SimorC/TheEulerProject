using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCode.Helper
{
    public class NumberHelper
    {
        public static bool CheckPrimeNumber(int number)
        {
            var divs = Enumerable.Range(2, (int)Math.Floor(Math.Sqrt(number))).Where(n => number % n == 0);
            return divs.Count() < 1;
        }

        public static bool CheckPrimeNumber(long number)
        {
            if (number == 1) return true;
            if (number == 2) return true;

            long floor = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 2; i < floor; i++)
            {
                if (number%i == 0) return false;
            }

            return true;
        }
    }
}
