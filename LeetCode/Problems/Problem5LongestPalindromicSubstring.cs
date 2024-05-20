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
using static System.Runtime.InteropServices.JavaScript.JSType;

/* 5. Longest Palindromic Substring
Given a string s, return the longest 
palindromic substring in s.

Hint 1
How can we reuse a previously computed palindrome to compute a larger palindrome?
Hint 2
If “aba” is a palindrome, is “xabax” a palindrome? Similarly is “xabay” a palindrome?
Hint 3
Complexity based hint:
If we use brute-force and check whether for every start and end position a substring is a palindrome we have O(n^2) start - end pairs and O(n) palindromic checks. Can we reduce the time for palindromic checks to O(1) by reusing some previous computation.
 

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.

Example 2:

Input: s = "cbbd"
Output: "bb"
 

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters.
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
    public class Problem5LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int[] ans = new int[] { 0, 0 }; // track lengths of start and end

            for (int i = 0; i < s.Length; i++)
            {
                int oddLength = Expand(s, i, i);
                ans = checkLengthAndUpdateAnswer(ans, i, oddLength, 0);

                int evenLength = Expand(s, i, i + 1);
                ans = checkLengthAndUpdateAnswer(ans, i, evenLength);
            }

            return s.Substring(ans[0], ans[1] - ans[0] + 1);
        }

        private int[] checkLengthAndUpdateAnswer(int[] ans, int i, int length, int evenValueOffset = 1)
        {
            if (length > ans[1] - ans[0] + 1)
            {
                int dist = (length / 2) - evenValueOffset;
                ans[0] = i - dist;
                ans[1] = i + dist + evenValueOffset;
            }
            return ans;
        }

        private int Expand(string s, int i, int j)
        {
            int left = i;
            int right = j;

            while (left >= 0 && right < s.Length && s[left] == s[right]) // grow when the strings match
            {
                left--;
                right++;
            }

            return right - left - 1; // return the length of the string
        }
    }
}
