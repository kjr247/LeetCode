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

/* 21. Merge Two Sorted Lists
Easy
Topics
Companies
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:


Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
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
    public class Problem21
    {
        // Setup for benchmark testing with data
        public Problem21()
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
        //[Time("File name: '{stringValueInput}'")]
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var results = new ListNode();
            return results;
        }

        public class ListNode
        {
             public int val;
             public ListNode next;
             public ListNode(int val = 0, ListNode next = null)
             {
                this.val = val;
                this.next = next;
             }
        }
    }
}
