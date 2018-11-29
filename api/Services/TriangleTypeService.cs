using System;

namespace api.Service
{
    public class TriangleTypes
    {
        enum Triangle { Scalene, Isosceles, Equilateral, Error }

        public string Calculate(int a, int b, int c)
        {
            if (a < 1 || b < 1 || c < 1)
            {
                return Triangle.Error.ToString();
            }
            else if (a == b && b == c)
            {
                return Triangle.Equilateral.ToString();
            }
            else if (a == b || b == c || a == c)
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