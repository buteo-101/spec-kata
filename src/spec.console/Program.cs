using BenchmarkDotNet.Running;
using SpecConsole.Benchmarks;
using SpecConsole.Services;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SpecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          
            BenchmarkRunner.Run<GetTargetGenBenchmarks>();
     


        }
    }

}

