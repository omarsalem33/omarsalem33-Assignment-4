```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Intel Core i7-8565U CPU 1.80GHz (Max: 1.99GHz) (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                     | Iterations | Mean             | Error          | StdDev           | Median           | Gen0       | Gen1    | Allocated   |
|--------------------------- |----------- |-----------------:|---------------:|-----------------:|-----------------:|-----------:|--------:|------------:|
| **StringConcatenation**        | **10**         |        **114.86 ns** |       **2.360 ns** |         **6.175 ns** |        **114.26 ns** |     **0.0802** |       **-** |       **336 B** |
| StringBuilderConcatenation | 10         |         65.08 ns |       1.285 ns |         2.625 ns |         64.56 ns |     0.0362 |       - |       152 B |
| **StringConcatenation**        | **100**        |      **2,567.30 ns** |     **134.649 ns** |       **377.569 ns** |      **2,382.39 ns** |     **4.9858** |       **-** |     **20856 B** |
| StringBuilderConcatenation | 100        |        822.88 ns |      29.346 ns |        86.067 ns |        793.25 ns |     0.3052 |       - |      1280 B |
| **StringConcatenation**        | **1000**       |    **187,100.80 ns** |   **2,720.668 ns** |     **2,793.925 ns** |    **186,480.42 ns** |   **678.9551** |       **-** |   **2840456 B** |
| StringBuilderConcatenation | 1000       |      7,615.10 ns |     134.637 ns |       144.061 ns |      7,563.33 ns |     3.5095 |       - |     14712 B |
| **StringConcatenation**        | **10000**      | **26,653,006.90 ns** | **503,372.661 ns** | **1,050,726.273 ns** | **26,397,515.62 ns** | **90062.5000** | **62.5000** | **379436456 B** |
| StringBuilderConcatenation | 10000      |     56,545.38 ns |   1,128.162 ns |     1,653.645 ns |     56,460.51 ns |    37.7197 |  4.6997 |    159424 B |
