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

/* 232. Implement Queue using Stacks
Easy
Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

Implement the MyQueue class:

void push(int x) Pushes element x to the back of the queue.
int pop() Removes the element from the front of the queue and returns it.
int peek() Returns the element at the front of the queue.
boolean empty() Returns true if the queue is empty, false otherwise.
Notes:

You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.
 

Example 1:

Input
["MyQueue", "push", "push", "peek", "pop", "empty"]
[[], [1], [2], [], [], []]
Output
[null, null, null, 1, 1, false]

Explanation
MyQueue myQueue = new MyQueue();
myQueue.push(1); // queue is: [1]
myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
myQueue.peek(); // return 1
myQueue.pop(); // return 1, queue is [2]
myQueue.empty(); // return false
 

Constraints:

1 <= x <= 9
At most 100 calls will be made to push, pop, peek, and empty.
All the calls to pop and peek are valid.
 

Follow-up: Can you implement the queue such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.
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
    public class Problem232ImplementQueueUsingStacks
    {
        // Setup for benchmark testing with data
        public Problem232ImplementQueueUsingStacks()
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;
        }

        /* Original Solution - no optimizations */
        /* LeetCode 50 ms Better than 90% of Users with C# */
        /* LeetCode 42ish MB Better than 35% of Users with C# */
        /* Time Complexity: O(n) */
        /* Space Complexity: O(n) increases linearly with the size of the input */
        /* Observations: the space is likely high because of all of the tostring calls. */
        [Time("File name Problem232ImplementQueueUsingStacks: input: ''")]
        public MyQueue ImplementQueueUsingStacks()
        {
            var result = new MyQueue();
            return result;
        }

        public class MyQueue
        {
            private Stack<int> s1, s2;

            private int front;

            public MyQueue()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();
            }

            public void Push(int x)
            {
                if(s1.Count == 0)
                {
                    front = x;
                }
                s1.Push(x);
            }

            public int Pop()
            {
                if(s2.Count == 0)
                {
                    while(s1.Count != 0)
                    {
                        s2.Push(s1.Pop());
                    }
                }
                return s2.Pop();
            }

            public int Peek()
            {
                if (s2.Count != 0)
                {
                    return s2.Peek();
                }
                return front;
            }

            public bool Empty()
            {
                return s1.Count == 0 && s2.Count == 0;
            }
        }

    }
}
