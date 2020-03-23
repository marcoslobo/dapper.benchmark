using BenchmarkDotNet.Running;
using System;

namespace benchmark.dapper.async
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DapperAsyncMethodBenchMark>();
        }
    }
}
