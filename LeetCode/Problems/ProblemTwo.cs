using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Problems
{
    public class ProblemTwo
    {
        // Time: O(n) for Array.reverse and Space: O(1) as it doesn't require any additional memory
        //public static bool IsPalindrome(int x)
        //{
        //    if (x < 0 || (x != 0 && x % 10 == 0))
        //    {
        //        return false;
        //    }

        //    var str = x.ToString();
        //    char[] charArray = str.ToCharArray();
        //    var len = str.Length;
        //    if (len % 2 == 0)
        //    {
        //        var add = len == 2 ? 1 : 0;
        //        char[] part1 = charArray.Take((len/2) - add).ToArray();
        //        char[] part2 = charArray.Skip((len/2) - add).Take(len / 2 - add).ToArray();
        //        Array.Reverse(part1);
        //        return new string(part1) == new string(part2);
        //    }
        //    else
        //    {
        //        Array.Reverse(charArray);
        //    }
            
        //    return new string(charArray) == x.ToString();
        //}


        // Follow up: Could you solve it without converting the integer to a string?

        // Space: O(n) for the while loop and Space: nearly O(1), the calculation produces smaller results as it runs
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }
            int reversed = 0;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }
            return (x == reversed) || (x == reversed / 10);
        }
    }
}
