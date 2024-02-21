using BenchmarkDotNet.Running;
using LeetCode.Problems;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            var summary = BenchmarkRunner.Run<Problem14>();
            Console.ReadLine();
        }
    }
}
