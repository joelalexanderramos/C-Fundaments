using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            foreach (var pm in primeMinisters.Keys)
            {
                Console.WriteLine(pm);
            }


            //var primeMinisters = new List<PrimeMinister>
            //{
            //    new PrimeMinister("James Callaghan", 1976),
            //    new PrimeMinister("Margaret Thatcher", 1979),
            //    new PrimeMinister("Tony Blair", 1997)
            //};

            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm);
            //}
        }
    }
}
