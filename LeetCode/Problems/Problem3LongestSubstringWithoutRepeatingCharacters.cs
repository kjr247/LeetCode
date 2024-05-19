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

/* 605. Can Place Flowers
 
You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false
 

Constraints:

1 <= flowerbed.length <= 2 * 104
flowerbed[i] is 0 or 1.
There are no two adjacent flowers in flowerbed.
0 <= n <= flowerbed.length
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
    public class Problem3LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var hash = new Dictionary<char, int>(); // tracking with a hash/dictionary using asci numerical values for characters
            int max = 0; // length of the longest substr
            int left = 0; // track the left pointer

            for (int right = 0; right < s.Length; right++) // iterating and moving right pointer
            {
                char rightChar = s[right]; // get the right char
                if (hash.ContainsKey(rightChar)) // check if exists in hash yet
                {
                    /* if the rightchar is already present in the tracking then check the last occurance of the character in string 
                     * and move it up one ahead of that since it was a dupe we can skip all chars until here */
                    left = Math.Max(left, hash[rightChar] + 1);
                }
                hash[rightChar] = right; // track the character and position now/after because if we did it before then it would throw off the checking
                max = Math.Max(max, right - left + 1); //checking the longest substring
            }
            return max;
        }
    }
}
