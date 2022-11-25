using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecConsole.Services
{

    public class Generation
    {
        public short Seed { get; set; }
        public int SeedNumber { get; set; }
        public List<short> Offsprings { get; set; }
        public long OffspringsCounts { get; set; }

        public long GetGenerationOffspringsCount()
        {
            //return SeedNumber * Offsprings.Count;
            return SeedNumber * OffspringsCounts;
        }



        public static List<Generation> GetFirstGenerations(List<short> seeds)
        {

            var firstGenerations = new List<Generation>();
            foreach (var seed in seeds)
            {
                var currentSeedGeneration = firstGenerations.FirstOrDefault(g => g.Seed == seed);
                if (null == currentSeedGeneration)
                {
                    firstGenerations.Add(new Generation
                    {
                        Offsprings = new List<short>() { seed },
                        Seed = seed,
                        SeedNumber = 1
                    });
                }
                if (null != currentSeedGeneration)
                {
                    currentSeedGeneration.SeedNumber += 1;
                }

            }
            return firstGenerations;
        }
    }
}
