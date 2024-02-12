using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ProblemTwo
    {
        // Time: O(n) for Array.reverse and Space: O(1) as it doesn't require any additional memory
        //    public static bool IsPalindrome(int x)
        //    {
        //        var results = false;
        //        var backwards = Reverse(x.ToString());
        //        results = backwards == x.ToString();
        //        return results;
        //    }

        //    public static string Reverse(string s)
        //    {
        //        char[] charArray = s.ToCharArray();
        //        Array.Reverse(charArray);
        //        return new string(charArray);
        //    }

        // Follow up: Could you solve it without converting the integer to a string?

        // Space: O(n) for the while loop and Space: nearly O(1), the calculation produces smaller results as it runs
        public static bool IsPalindrome(int x)
        {
            var results = false;
            // First thoughts - check the math? Since this is a number and not a string, you should be able to use an equation?
            results = checkPalindrome(x);
            return results;
        }

        static bool checkPalindrome(int n)
        {
            if (n != Math.Abs(n)) { return false; }
            int reverse = 0;
            int temp = n;
            while (temp != 0)
            {
                reverse = (reverse * 10) + (temp % 10);
                temp = temp / 10;
            }
            return ( reverse == n );
        }
    }
}
