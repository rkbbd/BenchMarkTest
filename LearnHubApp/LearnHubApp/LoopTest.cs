using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHubApp
{
    [MemoryDiagnoser(false)]
    public class LoopTest
    {
        public List<int> getData(int numberOfItem)
        {
            var numbers = Enumerable.Range(0, numberOfItem);
            return numbers.ToList();
        }
        [Benchmark]
        public List<int> ForLoop()
        {
            var numbers = getData(1000);
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] + 1;
            }
            return numbers;
        }

        [Benchmark]
        public List<int> ForEach()
        {
            var numbers = getData(1000);
            numbers.ForEach(x => x = 0);
            return numbers;
        }
    }
}
