```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9457/25H2/2025Update/HudsonValley2)
Intel Core i7-8565U CPU 1.80GHz (Max: 1.99GHz) (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                     | Mean       | Error     | StdDev     | Median     | Gen0     | Allocated  |
|--------------------------- |-----------:|----------:|-----------:|-----------:|---------:|-----------:|
| StringConcatenation        | 207.287 μs | 9.0235 μs | 25.7445 μs | 195.880 μs | 678.9551 | 2773.88 KB |
| StringBuilderConcatenation |   6.752 μs | 0.1141 μs |  0.2058 μs |   6.762 μs |   3.5095 |   14.37 KB |
