using System;

namespace Interfaces
{
    public class Octagon : Object, IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int lenght)
        {
            this.NumberOfSides = 8;
            this.SideLength = lenght;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 *Math.Sqrt(2));
        }

    }
}
