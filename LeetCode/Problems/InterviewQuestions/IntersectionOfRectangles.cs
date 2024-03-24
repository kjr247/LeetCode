using MethodMeasure;
using MethodTimer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


/*
Problem: Given lots of rectangles, output how many of them intersect.

Non-degeneracy assumption. All x- and y- coordinates are distinct.

Quadratic algorithm (naive algorithm) used to use range search. Check all pairs of rectangles for intersection.

Linearithmic Sweep-line algorithm using interval search which is N log N + R log N to find R intersections among a set of N rectangles

Pf. Sweep line reduces 2D orthogonal rectangle intersection search to 1D interval search (linearithmic time) instead of quadratic time.

- Put x-coordinates on a PQ or priority queue (or sort) <- N log N
- Insert y-intervals into ST or search tree             <- N log N
- Delete y-intervals from ST                            <- N log N
- Interval searches for y-intervals                     <- N log N + R log N

Based on https://massivealgorithms.blogspot.com/2019/01/rectangle-intersections-airbnb.html

Use union find.
Iterate all combination of points, and for each set of points, determine if they intersect.
If a set of points intersect, union them.
After forming all unions, the total number of intersections will be the number of unions.

Time O(n^2 * n) = O(n^3) since O(n^2) to iterate all combination of points and O(n) to union intersection.
Space O(n)

Is my solution correct?
My approach is brute-force approach given the time complexity.

After doing more research, there is a O(NlogN) approaching using sweep-line approach but I don't quite understand it (anyone code for this would be appricated especially in Java :) )
*/

namespace LeetCode.Problems.InterviewQuestions
{
    public class IntersectionOfRectangles
    {
        // Setup for benchmark testing with data
        public IntersectionOfRectangles()
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;
        }

        /* Original Solution - no optimizations */

        /* Time Complexity: O(n) linear based on input */
        /* Space Complexity: This grows in size dependent on its input it will create a copy 3 times including the result with numbers */
        /* Observations: the space is likely high because of all of the tostring calls. */

        [Time("File Name: IntersectionOfRectangles, Input: ''")]
        public Rectangle FindPointsOfIntersectingSquares(Dictionary<string, Rectangle> squares)
        {
            var result = new Rectangle();
            var rect1 = squares.Values.First();
            var rect2 = squares.Values.Last();

            if (rect1.IntersectsWith(rect2))
            {
                result = Rectangle.Intersect(rect1, rect2);
            }

            // change to return a list of 
            return result;
        }

        //bool valueInRange(int value, int min, int max)
        //{
        //    return (value >= min) && (value <= max);
        //}

        //bool findRectOverlap(List<List<int>> A, List<List<int>> B)
        //{
        //    var AX1 = A[0][0];
        //    var AX2 = A[1][0];
        //    var BX1 = B[0][1];
        //    var BX2 = B[1][1];

        //    var AY1 = A[0][1];
        //    var AY2 = A[1][1];
        //    var BY1 = B[0][1];
        //    var BY2 = B[1][1];

        //    //bool xOverlap = valueInRange(, B.Range.Values.ElementAt(0).Keys, B.Range.Values.Last) ||
        //    //                valueInRange(B.x, A.x, A.x + A.width);

        //    //bool yOverlap = valueInRange(A.y, B.y, B.y + B.height) ||
        //    //                valueInRange(B.y, A.y, A.y + A.height);

        //    //bool xOverlap = valueInRange(A.x, B.x, B.x + B.width) ||
        //    //    valueInRange(B.x, A.x, A.x + A.width);

        //    //bool yOverlap = valueInRange(A.y, B.y, B.y + B.height) ||
        //    //                valueInRange(B.y, A.y, A.y + A.height);


        //    return xOverlap && yOverlap;
        //}

    }
}
