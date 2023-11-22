```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3693/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method  | Mean     | Error     | StdDev    | Allocated |
|-------- |---------:|----------:|----------:|----------:|
| ForLoop | 1.635 μs | 0.0155 μs | 0.0137 μs |      4 KB |
| Foreach | 1.020 μs | 0.0127 μs | 0.0106 μs |      4 KB |
