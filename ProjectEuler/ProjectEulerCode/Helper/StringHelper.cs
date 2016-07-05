using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCode.Helper
{
    public class StringHelper
    {
        public static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            var strReversed = new String(str.ToCharArray().Reverse().ToArray());
            return str.Equals(strReversed);
        }

        public static bool IsPalindrome(int num)
        {
            string str = num.ToString();
            return IsPalindrome(str);
        }
    }
}
