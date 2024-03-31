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

/* 1768. Merge Strings Alternately
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
 

Constraints:

1 <= word1.length, word2.length <= 100
word1 and word2 consist of lowercase English letters.
*/


/* https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1846
 * Substring allocates a new string object on the heap and performs a full copy of the extracted text. 
 * String manipulation is a performance bottleneck for many programs. Allocating many small, short-lived strings on a hot path can create enough collection pressure to impact performance. 
 * The O(n) copies created by Substring become relevant when the substrings get large. The Span<T> and ReadOnlySpan<T> types were created to solve these performance problems.
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
    public class Problem1768MergeStringsAlternately
    {
        // Setup for benchmark testing with data
        public string[] AllStrings { get; set; }
        public Problem1768MergeStringsAlternately() 
        {
        }

        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder();
            var m = word1.Length;
            var n = word2.Length;
            var max = Math.Max(m, n); // single pointer

            for(var i = 0; i < max; i++)
            {
                if(i < m)
                {
                    sb.Append(word1[i]);
                }
                if (i < n)
                {
                    sb.Append(word2[i]);
                }
            }

            return sb.ToString();
        }
    }
}

