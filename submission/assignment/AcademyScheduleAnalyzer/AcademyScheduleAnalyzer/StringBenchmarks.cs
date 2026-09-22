using System.Text;
using BenchmarkDotNet.Attributes;

namespace AcademyScheduleAnalyzer;


[MemoryDiagnoser]

public class StringBenchmarks
{
    private const int Iterations = 1_000;

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