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
using MethodTimer;
using MethodMeasure;
using Microsoft.Extensions.Logging;

/* Problem 20. Valid Parentheses
Easy
Topics
Companies
Hint
Given a string stringValueInput containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: stringValueInput = "()"
Output: true
Example 2:

Input: stringValueInput = "()[]{}"
Output: true
Example 3:

Input: stringValueInput = "(]"
Output: false
 

Constraints:

1 <= stringValueInput.length <= 104
stringValueInput consists of parentheses only '()[]{}'.
*/

/* 
 * Notes on Optimizations
 * 
 * */
namespace LeetCode.Problems
{
    //[MemoryDiagnoser(true)]
    //[SimpleJob(RunStrategy.Throughput, launchCount: 4, warmupCount: 4, iterationCount: 40)]
    /*
     * Benchmarks from solution to solution
     */
    public class Problem20
    {
        // Setup for benchmark testing with data
        public Problem20()
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;
        }

        /* Original Solution - no optimizations */
        /* LeetCode 49 ms Better than 87.90% of Users with C# */
        /* LeetCode 40.30 MB Better than 8.01% of Users with C# */
        /* Time Complexity: O(n) on the for loop */
        /* Space Complexity: O(n) increases linearly with the size of the input */
        /* Observations: the space is likely high because of all of the tostring calls. */
        [Time("File name: '{stringValueInput}'")]
        public bool IsValid(string stringValueInput)
        {
            if (stringValueInput.Length % 2 != 0) { return false; } // if the string is odd size, then it is always false
            var beginningValues = new List<string> { "[", "{", "(" };
            var dict = new Dictionary<string, string>()
            {
                { "]", "[" },
                { "}", "{" },
                { ")", "(" }
            };
            const Boolean result = false;
            var stacker = new Stack<string>();

            for (int i = 0; i < stringValueInput.Length; i++)
            {
                // check if the target is in our beginnings beginningValues
                if (beginningValues.Contains(stringValueInput[i].ToString(), StringComparer.OrdinalIgnoreCase))
                {
                    stacker.Push(stringValueInput[i].ToString());
                }
                else // it is an end value
                {
                    var beginning = dict[stringValueInput[i].ToString()];

                    if (stacker.Count > 0 && stacker.Peek() == beginning)
                    {
                        stacker.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stacker.Count == 0) {
                return true;
            }
            return result;
        }

        public bool IsValid2(string stringValueInput)
        {
            if (stringValueInput != null && stringValueInput.Length % 2 != 0) { return false; } // if the string is odd size, then it is always false
            var beginningValues = new List<string> { "[", "{", "(" };
            var dict = new Dictionary<string, string>()
            {
                { "]", "[" },
                { "}", "{" },
                { ")", "(" }
            };
            const Boolean result = false;
            var stacker = new Stack<string>();

            for (int i = 0; i < stringValueInput.Length; i++)
            {
                // check if the target is in our beginnings beginningValues
                if (beginningValues.Contains(stringValueInput[i].ToString(), StringComparer.OrdinalIgnoreCase))
                {
                    stacker.Push(stringValueInput[i].ToString());
                }
                else // it is an end value
                {
                    var beginning = dict[stringValueInput[i].ToString()];

                    if (stacker.Count > 0 && stacker.Peek() == beginning)
                    {
                        stacker.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stacker.Count == 0)
            {
                return true;
            }
            return result;
        }
    }
}
