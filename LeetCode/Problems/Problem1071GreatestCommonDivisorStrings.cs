using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.TestData;
using BenchmarkDotNet.Engines;

/* 1071. Greatest Common Divisor of Strings
For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""
 

Constraints:

1 <= str1.length, str2.length <= 1000
str1 and str2 consist of English uppercase letters.
*/


/* 
 * */
/**
 */
namespace LeetCode.Problems
{

    [MemoryDiagnoser(true)]
    [SimpleJob(RunStrategy.Throughput, launchCount: 4, warmupCount: 4, iterationCount: 40)]
    /*
     * | Method               | strs      | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Allocated | Alloc Ratio |
     * |--------------------- |---------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|------------:|  
     */
    public class Problem1071GreatestCommonDivisorStrings
    {


        public string GcdOfStrings2(string str1, string str2)
        {
            var sb = new StringBuilder();
            var minWord = str1.Length < str2.Length ? str1 : str2;
            sb.Append(minWord);
            int len1 = str1.Length, len2 = str2.Length;

            for (var i = Math.Min(len1, len2); i >= 1; i++)
            {
                if (!str1.Contains(sb.ToString()) && !str2.Contains(sb.ToString())
                    && len1 % i != 0 && len2 % i != 0) {
                    continue;
                } else {
                    if (sb.Length == 0) { return sb.ToString(); }
                    var isGCD = str1.Replace(sb.ToString(), "").Length == 0 && str2.Replace(sb.ToString(), "").Length == 0;
                    if (isGCD) { return sb.ToString(); }
                }
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }

        public string GcdOfStrings(string str1, string str2)
        {
            // Check if they have non-zero GCD string.
            if ((str1 + str2) != (str2 + str1))
            {
                return "";
            }

            // Get the GCD of the two lengths.
            int gcdLength = gcd(str1.Length, str2.Length);
            return str1.Substring(0, gcdLength);
        }

        public int gcd(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }
        }
    }
}
