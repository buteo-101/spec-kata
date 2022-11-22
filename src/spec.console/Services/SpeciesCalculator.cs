using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecConsole.Services
{

    public class SpeciesCalculator
    {
        const short newBornValue = 8;
      
        public List<short> GetInnerClocksForGeneration(List<short> firstGenClocks, int iterations)
        {
            short gen = 0;
            var clocks = firstGenClocks;
            while (gen < iterations)
            {
                clocks = GetNextGenClocks(clocks);
                gen++;
            }
            return clocks;
        }

        public List<short> GetInnerClocksForGenerationWithMutations(List<short> firstGenClocks, int iterations)
        {
            short gen = 0;
            var clocks = firstGenClocks;
            while (gen < iterations)
            {
                GetNextGenClocksMutateArrays(ref clocks);
                gen++;
            }
            return clocks;
        }

        public List<short> GetInnerClocksForGenerationWithMutationsBySeed(List<short> firstGenClocks, int iterations)
        {         
            var clocks = new List<short>();

            foreach (var seed in firstGenClocks)
            {
                // get all spec generated in x generations by the first seed
                var clocksFromSeed = new List<short> { seed };
                short gen = 0;
                while (gen < iterations)
                {
                    //clocksFromSeed = GetNextGenClocks(clocksFromSeed);
                   GetNextGenClocksMutateArrays(ref clocksFromSeed);
                   gen++;
                }
                clocks.AddRange(clocksFromSeed);             

            }
            return clocks;
        }

        public List<short> GetInnerClocksForGenerationWithMutationsBySeedSlice(List<short> firstGenClocks, int iterations, int slice = 3)
        {
        
            var clocks = new List<short>();           

            for (int i = 0; i * slice < firstGenClocks.Count; i++)
            {
                // get all spec generated in x generations by the first seed
                var clocksFromSeed = firstGenClocks.Skip(i * slice).Take(slice).ToList();
                short gen = 0;
                while (gen < iterations)
                {
                    GetNextGenClocksMutateArrays(ref clocksFromSeed);
                    gen++;
                }
                clocks.AddRange(clocksFromSeed);
            }
            return clocks;
        }

        public List<short> GetNextGenClocks(List<short> clocks)
        {
            var newBorns = clocks.Count(c => c == 0);
            var nextClocks = clocks.Select(c => GetNextClock(c)).ToList();
            nextClocks.AddRange(Enumerable.Repeat(newBornValue, newBorns));
            return nextClocks.ToList();
        }


        public void GetNextGenClocksMutateArrays(ref List<short> clocks)
        {
            var newBorns = clocks.Count(c => c == 0);
            for (int i = 0; i < clocks.Count; i++)
            {
                clocks[i] = GetNextClock(clocks[i]);
            }

            clocks.AddRange(Enumerable.Repeat(newBornValue, newBorns));
        }



        public short GetNextClock(short  clock)
        {
            const short defaultNextValue = 6;
            const short step = 1;
         
            if (clock > 0)
            {
                return (short)(clock - step);
            }
            return defaultNextValue;
        }
    }
}
