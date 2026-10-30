```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Intel Core i7-8565U CPU 1.80GHz (Max: 1.99GHz) (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method              | Mean          | Error        | StdDev        | Gen0     | Allocated |
|-------------------- |--------------:|-------------:|--------------:|---------:|----------:|
| StringConcatenation | 199,255.00 ns | 5,809.020 ns | 16,667.170 ns | 678.9551 | 2840456 B |
| ArrayAllocation     |      10.59 ns |     0.274 ns |      0.281 ns |   0.0076 |      32 B |
| SpanUsage           |      15.70 ns |     0.339 ns |      0.416 ns |        - |         - |
