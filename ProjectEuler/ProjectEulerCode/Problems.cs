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
        ///  Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static string Problem1()
        {
            var sum = Enumerable.Range(1, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            return sum.ToString();
        }

        /// <summary>
        /// Each new term in the Fibonacci sequence is generated
        /// by adding the previous two terms. By starting with 1 and 2,
        /// the first 10 terms will be:
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed
        /// four million, find the sum of the even-valued terms.
        /// </summary>
        public static string Problem2()
        {
            int sum = 2;

            for (int f1 = 1, f2 = 2; f2 < 4000000;)
            {
                int temp = f1;
                f1 = f2;
                f2 += temp;

                sum += f2 % 2 == 0 ? f2 : 0;
            }

            return sum.ToString();
        }

        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public static string Problem3()
        {
            long number = 600851475143;
            long floor = (long) Math.Floor(Math.Sqrt(number));

            for (long i = floor; i > 0; i--)
            {
                if (number % i == 0 && NumberHelper.CheckPrimeNumber(i))
                {
                    return i.ToString();
                }
            }

            return "";
        }

        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome
        /// made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static string Problem4()
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

            return bigger.ToString();
        }

        /// <summary>
        /// 2520 is the smallest number that can be divided by each of
        /// the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible
        /// by all of the numbers from 1 to 20?
        /// </summary>
        public static string Problem5()
        {
            for (int i = 20; i < 9999999999; i+=20)
            {
                bool flagOk = true;

                for (int j = 1; j <= 20; j++)
                {
                    if (i % j != 0)
                    {
                        flagOk = false;
                        break;
                    }
                }

                if (flagOk) return i.ToString();
            }

            return "";
        }

        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// 12 + 22 + ... + 102 = 38
        /// The square of the sum of the first ten natural numbers is,
        /// (1 + 2 + ... + 10)2 = 552 = 3025
        /// Hence the difference between the sum of the squares of the
        /// first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// Find the difference between the sum of the squares of the
        /// first one hundred natural numbers and the square of the sum.
        /// </summary>
        /// <returns></returns>
        public static string Problem6()
        {
            int qtd = 100;

            return (NumberHelper.SquareOfSums(qtd) - NumberHelper.SumOfSquares(qtd)).ToString();
        }

        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10 001st prime number?
        /// </summary>
        /// <returns></returns>
        public static string Problem7()
        {
            int primes = 1;
            int i = 1;

            while (primes < 10001)
            {
                i++;
                primes += NumberHelper.CheckPrimeNumber(i) ? 1 : 0;
            }

            return i.ToString();
        }
    }
}
