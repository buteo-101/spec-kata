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
            //BenchmarkRunner.Run<GetNextenBenchmarks>();
            BenchmarkRunner.Run<GetTargetGenBenchmarks>();
            //var InnerClocksList = new List<int[]>();
            //int[] InnerClocks = new int[] { 3, 4, 3, 1, 2 };

            //InnerClocksList.Add(InnerClocks);
            //var _calculator = new SpeciesNestedCalculator();
            //var computedGen = _calculator.GetInnerClocksForGeneration(InnerClocksList, 80);
            //Console.WriteLine(JsonSerializer.Serialize(computedGen));
            //Console.WriteLine(computedGen.Count);
            //var _calculator = new SpeciesCalculator();
            //int[] InnerClocks = new int[] { 3, 4, 3, 1, 2 };
            //var computedGen = _calculator.GetInnerClocksForGeneration(InnerClocks, 200);
            //Console.WriteLine(JsonSerializer.Serialize(computedGen));



        }
    }

}

