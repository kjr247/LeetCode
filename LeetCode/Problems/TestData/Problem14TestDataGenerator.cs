using BenchmarkDotNet.Attributes;
using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TestData
{
    [MemoryDiagnoser]
    public class Problem14TestDataGenerator
    {
        public Faker<StringsFake> StringsRecordFake { get; set; }

        public class StringsFake()
        {
            public string[] AllStrings { get; set; }
        }

        public Problem14TestDataGenerator()
        {
            Setup();
        }

        public StringsFake GenerateArrayOfStrings()
        {
            return StringsRecordFake.Generate();
        }

        [Params(10, 1000, 10000, 100000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            Randomizer.Seed = new Random(123);

            string[] strs = [
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",            
            ];

            var fak = new Faker();

            StringsRecordFake = new Faker<StringsFake>()
                .RuleFor(o => o.AllStrings, f => Enumerable.Range(1, Size)
                    .Select(_ => fak.PickRandom(strs)).ToArray());
        }

    }
}
