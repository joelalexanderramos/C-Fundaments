using System;

namespace Interfaces
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int lenght) :
            base(3, lenght) { }

        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
