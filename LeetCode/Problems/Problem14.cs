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
/**
 * In the best case the array is already sorted and we can begin with just using the shortest string, because that will be the limitation on the largest common prefix.
 * 
 * also sorting alphebetically, you can easily force the like texts into groups.
 * 
 * For the sake of the ability to read the code by a larger group, Regex was not used.
 */
namespace LeetCode.Problems
{
    public class Problem14
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) { return strs[0]; }
            if (strs[0].Length == 0) { return ""; }
            var results = "";
            var match = "";

            for (int i = 0; i < strs[0].Length; i++)
            {

                match += strs[0][i];
                for (int jWord = 0; jWord < strs.Length; jWord++)
                {
                    if (jWord == 0) { continue; }

                    if (strs[jWord].StartsWith(match, false, CultureInfo.InvariantCulture))
                    {
                        if (jWord >= strs.Length - 1)
                        {
                            results = match;
                            if (i >= strs[0].Length) { return results; }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return results;
        }
    }
}

/**
 * Lessons learned, for loop is 2 times cheaper than foreach
 * looping an array is 2 times cheaper than looping foreach on a list.
 * looping arrays on for loop is roughly 5 times cheaper than looping a list on a foreach
 */

