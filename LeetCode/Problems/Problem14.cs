using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14.Longest Common Prefix
//Easy
//Topics
//Companies
//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".

//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.


//Constraints:

//1 <= strs.length <= 200
//0 <= strs[i].length <= 200
//strs[i] consists of only lowercase English letters.


/* https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1846
 * Substring allocates a new string object on the heap and performs a full copy of the extracted text. 
 * String manipulation is a performance bottleneck for many programs. Allocating many small, short-lived strings on a hot path can create enough collection pressure to impact performance. 
 * The O(n) copies created by Substring become relevant when the substrings get large. The Span<T> and ReadOnlySpan<T> types were created to solve these performance problems.
 * */

namespace LeetCode.Problems
{
    public class Problem14
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) { return strs[0]; }
            if (strs[0].Length == 0) { return ""; }
            var results = "";
            var iWord = 0;
            var iLetter = 1;

            foreach (char letter in strs[0])
            {
                iWord = 0;
                foreach (string word in strs)
                {
                    if (iWord == 0) { iWord++; continue; }

                    if (word.StartsWith(strs[0].Substring(0, iLetter), false, CultureInfo.InvariantCulture))
                    {
                        if (iWord >= strs.Length - 1)
                        {
                            results = strs[0].Substring(0, iLetter);
                            if (iLetter >= strs[0].Length) { return results; }
                        }
                    }
                    else
                    {
                        break;
                    }
                    iWord++;
                }
                iLetter++;
            }
            return results;
        }
    }
}



