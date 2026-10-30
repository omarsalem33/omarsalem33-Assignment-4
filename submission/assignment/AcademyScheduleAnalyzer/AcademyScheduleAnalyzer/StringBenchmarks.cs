using System.Text;
using BenchmarkDotNet.Attributes;

namespace AcademyScheduleAnalyzer;


[MemoryDiagnoser]

public class StringBenchmarks
{
    [Params(10, 100, 1000, 10000)]
    public int Iterations { get; set; }

    [Benchmark]
    public string StringConcatenation()
    {
        string res = string.Empty;
        for (int i = 0; i < Iterations; i++)
        {
            res += i.ToString();
        }
        return res;
    }
    
    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder res = new  StringBuilder();
        for (int i = 0; i < Iterations; i++)
        {
            res.Append(i);
        }
        return res.ToString();
    }
}