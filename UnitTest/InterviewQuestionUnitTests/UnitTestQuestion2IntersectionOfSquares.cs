using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Bogus;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using UnitTest.TestData;
using MethodTimer;
using LeetCode.InterviewQuestions;
using System.Drawing;
using LeetCode.Problems.InterviewQuestions;

namespace UnitTest
{
    [TestClass]
    public class UnitTestQuestion2IntersectionOfSquares
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        public Dictionary<string, Rectangle> GenerateTestData()
        {
            Rectangle rectangle1 = new Rectangle(50, 50, 100, 200);
            Rectangle rectangle2 = new Rectangle(70, 20, 100, 200);

            var testData = new Dictionary<string, Rectangle> ();

            testData.Add("SquareA", rectangle1);
            testData.Add("SquareB", rectangle2);
            return testData;
        }

        [Time]
        [TestMethod]
        public void TestMethod1()
        {
            /*
             * x1 = 70 from b is bigger than 50 from a
             * x2 = 150 from a - 50 + 100 = 150 is smaller than 170
             * y1 = 50 is bigger than 20 so it's 50 from b
             * y2 = 220 from b is smaller 50 + 200 from a is 250 and 20 + 200 from b is 220
             * x2 150a >= x1 70b && y2 220b >= y1 50b
             */
            var IV = new IntersectionOfRectangles();
            var val = GenerateTestData();
            var result = IV.FindPointsOfIntersectingSquares(val);
            var rect = new Rectangle(70, 50, 80, 170);
            Assert.AreEqual(rect.X, result.X);
            Assert.AreEqual(rect.Y, result.Y);
            Assert.AreEqual(rect.Width, result.Width);
            Assert.AreEqual(rect.Height, result.Height);
        }
    }
}