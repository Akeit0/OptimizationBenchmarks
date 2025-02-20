using System.Runtime.CompilerServices;

namespace MethodCallBenchmarks;

public class BenchmarkBase
{
    protected static string GetAbsolutePath(string relativePath,[CallerFilePath] string callerFilePath = "")
    {
        return Path.Combine(Path.GetDirectoryName(callerFilePath)!, relativePath);
    }
}