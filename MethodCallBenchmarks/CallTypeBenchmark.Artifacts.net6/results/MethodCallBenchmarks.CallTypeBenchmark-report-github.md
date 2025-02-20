```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
13th Gen Intel Core i7-13700F, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Code Size |
|--------------------------------------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|
| CallDirect                             | 0.5507 ns | 0.9892 ns | 0.0542 ns | 0.5768 ns |  1.01 |    0.13 |      24 B |
| CallInterface                          | 1.2813 ns | 0.9851 ns | 0.0540 ns | 1.2591 ns |  2.34 |    0.23 |      46 B |
| CallInterfaceNoTiered                  | 2.2386 ns | 0.2921 ns | 0.0160 ns | 2.2379 ns |  4.09 |    0.37 |      74 B |
| CallInterfaceStaticReadOnly            | 0.0282 ns | 0.7509 ns | 0.0412 ns | 0.0093 ns |  0.05 |    0.07 |       3 B |
| CallDelegateStaticReadOnly             | 0.1311 ns | 0.0687 ns | 0.0038 ns | 0.1302 ns |  0.24 |    0.02 |      35 B |
| CallDelegate                           | 0.5012 ns | 0.0981 ns | 0.0054 ns | 0.4981 ns |  0.92 |    0.08 |      35 B |
| CallDelegateNoTiered                   | 2.1521 ns | 0.5494 ns | 0.0301 ns | 2.1672 ns |  3.93 |    0.36 |      63 B |
| CallStaticMethodDelegateStaticReadOnly | 2.0709 ns | 3.0173 ns | 0.1654 ns | 2.0107 ns |  3.79 |    0.43 |      35 B |
| CallStaticMethodDelegate               | 1.9958 ns | 0.7658 ns | 0.0420 ns | 2.0017 ns |  3.65 |    0.34 |      35 B |
| CallStaticMethodDelegateNoTiered       | 2.3247 ns | 0.5166 ns | 0.0283 ns | 2.3395 ns |  4.25 |    0.39 |      63 B |
| CallFunctionPointerStaticReadOnly      | 0.1454 ns | 0.1939 ns | 0.0106 ns | 0.1421 ns |  0.27 |    0.03 |      32 B |
| CallFunctionPointer                    | 1.7347 ns | 1.5508 ns | 0.0850 ns | 1.7800 ns |  3.17 |    0.32 |      29 B |
| CallFunctionPointerNoTiered            | 1.9360 ns | 2.0783 ns | 0.1139 ns | 1.9135 ns |  3.54 |    0.37 |      57 B |
