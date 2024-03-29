using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

//    Symbol       Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000
//For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

//    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

//    I can be placed before V (5) and X (10) to make 4 and 9. 
//    X can be placed before L (50) and C (100) to make 40 and 90. 
//    C can be placed before D (500) and M (1000) to make 400 and 900.
//    Given a roman numeral, convert it to an integer.

// O(n) on run time and O(1) on constant storage complexity
namespace LeetCode.Problems
{
    public class Problem13
    {
        // O(1) but it's possible to do this without putting this into memory and instead add a switch case with else if statements with a lookahead algorithm
        public static readonly Dictionary<char, int> RomanNumeralsMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        // O(n) linear because this runs a loop through one time based on the size of the input growing linearly with the size of input
        public static int RomanToInt(string s)
        {
            var result = 0;
            var prevValue = 0;

            foreach (var c in s)
            {
                int val = RomanNumeralsMap[c];
                result += val;

                if (prevValue < val)
                {
                    result -= 2 * prevValue;
                }

                prevValue = val;
            }
            return result;
        }
    }
}
