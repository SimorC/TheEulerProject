using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerCode.Helper;

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

        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public static void Problem3()
        {
            long number = 600851475143;
            long floor = (long) Math.Floor(Math.Sqrt(number));

            for (long i = floor; i > 0; i--)
            {
                if (number % i == 0 && NumberHelper.CheckPrimeNumber(i))
                {
                    Console.WriteLine(i);
                    break;
                }
                
            }

            
        }

        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome
        /// made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static void Problem4()
        {
            int bigger = 0;
            for (int i = 999; i > 1; i--)
            {
                for (int j = 999; j > 1; j--)
                {
                    int prod = i * j;
                    if (prod <= bigger) continue;

                    if (StringHelper.IsPalindrome(prod))
                    {
                        bigger = prod;
                        break;
                    }
                }
            }

            Console.WriteLine(bigger);
        }
    }
}
