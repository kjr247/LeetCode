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

/* 14.Longest Common Prefix
Easy
Topics
Companies
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower", "flow", "flight"]
Output: "fl"
Example 2:

Input: strs = ["dog", "racecar", "car"]
Output: ""
Explanation: There is no common prefix among the input strings.


Constraints:

 1 <= strs.length <= 200
 0 <= strs[idxLetter].length <= 200
 strs[idxLetter] consists of only lowercase English letters.
*/


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

    [MemoryDiagnoser(true)]
    [SimpleJob(RunStrategy.Throughput, launchCount: 4, warmupCount: 4, iterationCount: 40)]
    /*
     * | Method               | strs      | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Allocated | Alloc Ratio |
     * |--------------------- |---------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|------------:|
     * | LongestCommonPrefix  | String[0] | 0.2683 ns | 0.0162 ns | 0.0607 ns | 0.2645 ns |  1.00 |    0.00 |         - |          NA |
     * | LongestCommonPrefix2 | String[0] | 0.0658 ns | 0.0191 ns | 0.0708 ns | 0.0525 ns |  0.25 |    0.26 |         - |          NA |    
     */
    public class Problem14
    {
        // Setup for benchmark testing with data
        public string[] AllStrings { get; set; }
        public Problem14() 
        {
            var gen = new Problem14TestDataGenerator();
            var obj = new Problem14TestDataGenerator.StringsFake();
            obj = gen.GenerateArrayOfStrings();
            AllStrings = obj.AllStrings;
        }

        public IEnumerable<object> ProvidedAllStrings() // for single argument it's an IEnumerable of objects (object)
        {
            yield return AllStrings;
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(ProvidedAllStrings))]
        /* Original Solution */
        public string LongestCommonPrefix(string[] strs)
        {
            if(strs == null || strs.Length == 0 ) { return ""; }
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

        [Benchmark]
        [ArgumentsSource(nameof(ProvidedAllStrings))]
        /* Optimized Solution */
        public string LongestCommonPrefix2(string[] strs)
        {
            if(strs == null || strs.Length == 0 ) { return ""; }
            if (strs.Length == 1) { return strs[0]; }
            if (strs[0].Length == 0) { return ""; }
            var results = "";
            var checkMatch = "";
            int idxLetter = 0;
            int idxWord = 0;
            for (idxLetter = 0; idxLetter < strs[0].Length; idxLetter++)
            {

                checkMatch += strs[0][idxLetter];
                for (idxWord = 0; idxWord < strs.Length; idxWord++)
                {
                    if (idxWord == 0) { continue; }

                    if(idxLetter < strs[idxWord].Length && strs[idxWord][idxLetter] == strs[0][idxLetter]) // is matching letters?
                    {
                        if (idxWord >= strs.Length - 1)
                        {
                            results = checkMatch;
                            if (idxLetter >= strs[0].Length) { 
                                return results; 
                            }
                        }
                    }
                    else // no more matches
                    {
                            return results;
                    }
                }
            }
            return results;
        }
    }
}

/**
 * For loop is 2 times cheaper than foreach
 * looping an array is 2 times cheaper than looping foreach on a list.
 * looping arrays on for loop is roughly 5 times cheaper than looping a list on a foreach
 */

