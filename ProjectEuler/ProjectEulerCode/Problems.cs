using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCode
{
    public class Problems
    {
        /// <summary>
        /// If we list all the natural numbers below 10
        /// that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        /// The sum of these multiples is 23.
        //  Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static void Problem1()
        {
            var sum = Enumerable.Range(1, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Each new term in the Fibonacci sequence is generated
        /// by adding the previous two terms. By starting with 1 and 2,
        /// the first 10 terms will be:
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed
        /// four million, find the sum of the even-valued terms.
        /// </summary>
        public static void Problem2()
        {
            int sum = 2;

            for (int f1 = 1, f2 = 2; f2 < 4000000;)
            {
                int temp = f1;
                f1 = f2;
                f2 += temp;

                sum += f2 % 2 == 0 ? f2 : 0;
            }

            Console.WriteLine(sum);
        }
    }
}
