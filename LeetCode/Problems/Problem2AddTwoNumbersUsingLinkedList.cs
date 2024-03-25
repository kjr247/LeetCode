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
using Bogus.Bson;
using Microsoft.Extensions.Primitives;

/* 2. Add Two Numbers
Medium
Topics
Companies
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
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
    public class Problem2AddTwoNumbersUsingLinkedList
    {
        // Setup for benchmark testing with data
        public Problem2AddTwoNumbersUsingLinkedList()
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;
        }

        /* Original Solution - no optimizations */
        /* LeetCode 65 ms Better than 94% of Users with C# */
        /* LeetCode 51ish MB Better than 92% of Users with C# */
        /* Time Complexity: O(n) for most things, O(1) for insertion and deletion */
        /* Space Complexity: O(n) increases linearly with the size of the input */
        /* Observations: the space is likely high because of all of the tostring calls. */
        [Time("File name Problem2AddTwoNumbersUsingLinkedList: input: ''")]
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode firstNodeResult = new ListNode(0);
            ListNode currentNode = firstNodeResult;
            while(l1 != null || l2 != null || carry != 0)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                sum += carry;
                carry = sum / 10; // gets the carry
                // create the next node using a single digit of the sum while carry is used in the next iteration
                ListNode node = new ListNode(sum % 10);
                currentNode.next = node; // create the link
                currentNode = node; // look at the next node on next iteration
            }

            return firstNodeResult.next; // returns the first of the chain of linked nodes in the linked list
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
