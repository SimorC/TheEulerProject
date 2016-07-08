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
            if (number == 1) return false;
            if (number == 2) return true;

            var divs = Enumerable.Range(2, (int)Math.Floor(Math.Sqrt(number))).Where(n => number % n == 0);
            return divs.Count() < 1;
        }

        public static bool CheckPrimeNumber(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            long floor = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 2; i < floor; i++)
            {
                if (number%i == 0) return false;
            }

            return true;
        }

        public static int SumOfSquares(int qtd)
        {
            int sum = 0;

            for (int i = 1; i <= qtd; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }

            return sum;
        }

        public static int SquareOfSums(int qtd)
        {
            int sum = Enumerable.Range(1, qtd).Sum();

            return (int)Math.Pow(sum, 2);
        }
    }
}
