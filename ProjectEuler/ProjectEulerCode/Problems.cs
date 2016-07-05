﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCode
{
    public class Problems
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        /// The sum of these multiples is 23.
        //  Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static void Problem1()
        {
            var sum = Enumerable.Range(1, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine(sum);
        }

        public static void Problem2()
        {
            Console.WriteLine("Second problem");
        }
    }
}