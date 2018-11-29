using System;

namespace api.Service
{
    public class TriangleTypes
    {
        enum Triangle { Scalene, Isosceles, Equilateral, Error }

        public string Calculate(int side1, int side2, int side3)
        {
            if (side1 < 1 || side2 < 1 || side3 < 1)
            {
                return Triangle.Error.ToString();
            }
            else if (side1 == side2 && side2 == side3)
            {
                return Triangle.Equilateral.ToString();
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return Triangle.Isosceles.ToString();
            }
            else
            {
                return Triangle.Scalene.ToString();
            }
        }
    }
}