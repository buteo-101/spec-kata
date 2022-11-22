using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecConsole.Services
{
    public class SpeciesNestedCalculator
    {
        public List<int> GetInnerClocksForGeneration(List<int[]> firstGenClocks, int iterations)
        {
            int gen = 0;
            var clocks = firstGenClocks;
            while (gen < iterations)
            {
                clocks = GetNextGenNestedClocks(clocks);
                gen++;
            }
            return clocks.SelectMany(r => r).ToList();
        }

        private List<int[]> GetNextGenNestedClocks(List<int[]> clocks)
        {
            // get newBorns Count 
            var newBorns = GetNewBornsCount(clocks);

            for (int i = 0; i < clocks.Count; i++)
            {
                // mutate row in place
                clocks[i] = clocks[i].Select(c => GetNextClock(c)).ToArray();
            }
            // add new borns
            clocks.Add(Enumerable.Repeat(8, newBorns).ToArray());
            return clocks;
        }



        public int GetNewBornsCount(List<int[]> clocks)
        {
            return clocks.Sum(r => r.Count(c => c == 0));
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
