```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
13th Gen Intel Core i7-13700F, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Mean      | Error     | StdDev    | Ratio | Code Size |
|--------------------------------------- |----------:|----------:|----------:|------:|----------:|
| CallDirect                             | 0.3313 ns | 0.0092 ns | 0.0005 ns | 1.000 |      25 B |
| CallInterface                          | 0.0992 ns | 0.0069 ns | 0.0004 ns | 0.299 |      72 B |
| CallInterfaceNoTiered                  | 1.1049 ns | 0.0590 ns | 0.0032 ns | 3.335 |      73 B |
| CallInterfaceStaticReadOnly            | 0.0131 ns | 0.0554 ns | 0.0030 ns | 0.040 |       3 B |
| CallDelegateStaticReadOnly             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.000 |      51 B |
| CallDelegate                           | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.000 |      51 B |
| CallDelegateNoTiered                   | 0.9105 ns | 0.0115 ns | 0.0006 ns | 2.748 |      66 B |
| CallStaticMethodDelegateStaticReadOnly | 1.0997 ns | 0.0162 ns | 0.0009 ns | 3.319 |      32 B |
| CallStaticMethodDelegate               | 1.0931 ns | 0.0230 ns | 0.0013 ns | 3.299 |      32 B |
| CallStaticMethodDelegateNoTiered       | 1.3197 ns | 0.0660 ns | 0.0036 ns | 3.983 |      66 B |
| CallFunctionPointerStaticReadOnly      | 0.9251 ns | 0.0898 ns | 0.0049 ns | 2.792 |      23 B |
| CallFunctionPointer                    | 0.9337 ns | 0.1004 ns | 0.0055 ns | 2.818 |      20 B |
| CallFunctionPointerNoTiered            | 0.9235 ns | 0.0066 ns | 0.0004 ns | 2.787 |      54 B |
