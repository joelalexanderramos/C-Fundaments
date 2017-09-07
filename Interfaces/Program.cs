using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);

        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"--- {polygonType.ToUpper()}  ----");
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}" );
                Console.WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
                Console.WriteLine($"{polygonType} Side Length: {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygonType} Side Length: {polygon.GetArea():0.00}");
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
