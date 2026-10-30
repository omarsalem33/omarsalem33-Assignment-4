using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MemoryBenchmarking
{
    // Enables GC and allocation reporting columns
    [MemoryDiagnoser]
    public class AllocationBenchmark
    {
        private const int Size = 1_000;

        [Benchmark]
        public string StringConcatenation()
        {
            string result = string.Empty;
            for (int i = 0; i < Size; i++)
            {
                result += i.ToString(); // Allocates string instances on each loop iteration
            }
            return result;
        }

        [Benchmark]
        public string ArrayAllocation()
        {
            var array = new int[Size]; // Allocates managed memory for the array
            return array.Length.ToString();
        }

        [Benchmark]
        public int SpanUsage()
        {
            Span<int> buffer = stackalloc int[128]; // Allocates on stack (0 managed allocations)
            return buffer.Length;
        }
    }
}