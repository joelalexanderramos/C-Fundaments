using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparisons
{
    class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine("Operator: " + AreIntsEqualOp(3,3));
            //Console.WriteLine("Method: " + AreIntsEqualMethod(3, 3));           

            //string s1 = "Joel";
            //string s2 = "Joel";

            //Console.WriteLine(s1 == s2);

            // -- STRING COMPARISON
            //string s1 = "Joel";
            //string s2 = "joel";

            //s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
        }

        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y;
        }

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y);
        }
    }
}
