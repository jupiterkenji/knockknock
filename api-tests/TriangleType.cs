using System;
using Xunit;
using api.Service;

namespace readifyknockknock.test
{
    public class TriangleTypesTest
    {
        [Fact]
        public void TestCalculate()
        {
            var service = new TriangleTypes();
            Assert.Equal("Equilateral", service.Calculate(3, 3, 3));
            Assert.Equal("Isosceles", service.Calculate(3, 4, 4));
            Assert.Equal("Scalene", service.Calculate(3, 4, 5));
        }

        [Fact]
        public void TestCalculate_Negative()
        {
            var service = new TriangleTypes();
            Assert.Equal("Error", service.Calculate(-3, 3, 3));
            Assert.Equal("Error", service.Calculate(3, -4, 4));
            Assert.Equal("Error", service.Calculate(3, 4, -5));
        }
    }
}
