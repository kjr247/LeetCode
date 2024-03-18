using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.Roslyn;
using LeetCode.Problems;
using MethodMeasure;
using Microsoft.Extensions.Logging;

namespace LeetCode
{
    internal static class Program
    {
        static void Main(/*string[] args*/)
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;

            Console.WriteLine("Begin");
            //var thing = new Problem20();
            //var result = true;
            //for (int i = 0; i < 1000; i++)
            //{
            //    result = thing.IsValid("[{}]");
            //}

            var summary = BenchmarkRunner.Run<Problem14>();
            Console.ReadLine();
        }
    }
}
