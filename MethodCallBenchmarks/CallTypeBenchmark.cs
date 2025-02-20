using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace MethodCallBenchmarks;

[DisassemblyDiagnoser(exportGithubMarkdown: true)]
[Config(typeof(CallTypeBenchmark.Config))]
[ShortRunJob]
public unsafe class CallTypeBenchmark : BenchmarkBase
{
    class Config : ManualConfig
    {
        public Config()
        {
            ArtifactsPath = GetAbsolutePath("CallTypeBenchmark.Artifacts");
        }
    }

    static IEqualityComparer<int> comparer = EqualityComparer<int>.Default;

    static Func<int, int, bool> comparerFunc = (x, y) => x == y;
    static readonly Func<int, int, bool> comparerFuncStaticReadOnly = (x, y) => x == y;

    static Func<int, int, bool> comparerStaticFunc = Compare;
    static readonly Func<int, int, bool> comparerStaticFuncStaticReadOnly = Compare;


    static delegate*<int, int, bool> comparerFuncPointer = &Compare;
    static readonly delegate*<int, int, bool> comparerFuncPointerStaticReadOnly = &Compare;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static bool Compare(int x, int y) => x == y;

    [Benchmark(Baseline = true)]
    public bool CallDirect()
    {
        return Compare(1, 2);
    }

    [Benchmark]
    public bool CallInterface() => comparer.Equals(1, 2);

    [Benchmark]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public bool CallInterfaceNoTiered() => comparer.Equals(1, 2);


    [Benchmark]
    public bool CallInterfaceStaticReadOnly() => EqualityComparer<int>.Default.Equals(1, 2);
    
    [Benchmark]
    public bool CallDelegateStaticReadOnly() => comparerFuncStaticReadOnly(1, 2);

    [Benchmark]
    public bool CallDelegate() => comparerFunc(1, 2);

    [Benchmark]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public bool CallDelegateNoTiered() => comparerFunc(1, 2);

    [Benchmark]
    public bool CallStaticMethodDelegateStaticReadOnly() => comparerStaticFuncStaticReadOnly(1, 2);

    [Benchmark]
    public bool CallStaticMethodDelegate() => comparerStaticFunc(1, 2);

    [Benchmark]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public bool CallStaticMethodDelegateNoTiered() => comparerStaticFunc(1, 2);

    [Benchmark]
    public bool CallFunctionPointerStaticReadOnly() => comparerFuncPointerStaticReadOnly(1, 2);

    [Benchmark]
    public bool CallFunctionPointer() => comparerFuncPointer(1, 2);

    [Benchmark]
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public bool CallFunctionPointerNoTiered() => comparerFuncPointer(1, 2);
}