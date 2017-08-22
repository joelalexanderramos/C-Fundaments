using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter names: ");
            string[] names = Console.ReadLine().Split(' ');

            int hoursSleep;

            Console.WriteLine("Hours sleep: ");
            int.TryParse(Console.ReadLine(), out hoursSleep);

            #region Hours of Sleep
            if (hoursSleep > 8)
                Console.WriteLine("You are well rested");
            else
                Console.WriteLine("You need more sleep");
            #endregion

            #region Names split
            if (names.Length > 0)
                foreach (var arg in names)
                {
                    Console.WriteLine(String.Format("Hello, {0}", arg.ToString()));
                }

            else
                Console.WriteLine("Hello, world"); 
            #endregion
        }
    }
}
