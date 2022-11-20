using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecConsole.Services
{
  
    public class SpeciesCalculator
    {

        

        public int[] GetInnerClocksForGeneration(int[] firstGenClocks, int iterations)
        {
            int gen = 0;
            var clocks = firstGenClocks;
            while (gen < iterations)
            {
                clocks = GetNextGenClocks(clocks);
                gen++;
            }
            return clocks;
        }

        public int[] GetInnerClocksForGenerationWithMutations(int[] firstGenClocks, int iterations)
        {
            int gen = 0;
            var clocks = firstGenClocks;
            while (gen < iterations)
            {
                GetNextGenClocksMutateArrays(ref clocks);
                gen++;
            }
            return clocks;
        }

        public int[] GetNextGenClocks(int[] clocks)
        {
            var newBorns = clocks.Count(c => c == 0);
            var nextClocks = clocks.Select(c => GetNextClock(c)).ToList();
            nextClocks.AddRange(Enumerable.Repeat(8, newBorns));
            return nextClocks.ToArray();

        }
        public void GetNextGenClocksMutateArrays(ref int[] clocks)
        {
            var newBorns = clocks.Count(c => c == 0);
            for(int i = 0; i < clocks.Length; i++)
            {
                clocks[i] =  GetNextClock(clocks[i]);
            }
            for(int i = 0; i < newBorns; i++)
            {
                clocks.Append(8);
            }
        
        }

        public int GetNextClock(int clock)
        {
            if (clock > 0)
            {
                return clock - 1;
            }
            return 6;
        }
    }
}
