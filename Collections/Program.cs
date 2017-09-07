using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new HashSet<string>
                (new UncasedStringEquialityComparer())
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            //cities.Add("SHEFFIELD");
            //cities.Add("BEIJING");

            // Intercept
            string[] citiesUNK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            cities.IntersectWith(citiesUNK);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //var primeMinisters = new SortedList<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            //{
            //    { "JC" , new PrimeMinister("James Callaghan", 1976)},
            //    { "MT" , new PrimeMinister("Margaret Thatcher", 1979)},
            //    { "TB" , new PrimeMinister("Tony Blair", 1997)}
            //};
            //// Sorted Dictionary
            //primeMinisters.Add("JM", new PrimeMinister("John Major", 1990));


            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm);
            //}

            // ReadOnly Dictionary
            //var psmReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);

            //foreach (var pm in psmReadOnly)
            //{
            //    Console.WriteLine(pm.Value);
            //}

            // ignoring case
            //Console.WriteLine(primeMinisters["tb"]);

            //// adding
            //primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));

            //// modifying
            ////primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);

            //Console.WriteLine("--- BEFORE ---");
            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm);
            //}

            //// removing
            //Console.WriteLine("--- AFTER ---");
            //primeMinisters.Remove("GB");
            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm);
            //}

            //// Looking up
            //PrimeMinister pm;

            //bool found = primeMinisters.TryGetValue("DC", out pm);
            //if (found)            
            //    Console.WriteLine("value is: " + pm.ToString());
            //else
            //    Console.WriteLine("value was not in the dictionary");

            //var pm = primeMinisters["MT"];
            //Console.WriteLine("Value is: " + pm.ToString());


            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm.Key + ",    " + pm.Value);
            //}
        }

        class UncasedStringEquialityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return x.ToUpper() == y.ToUpper();
            }

            public int GetHashCode(string obj)
            {
                return obj.ToUpper().GetHashCode();
            }
        }


    }
}
