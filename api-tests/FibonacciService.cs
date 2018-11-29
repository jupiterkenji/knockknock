using System;
using Xunit;
using api.Service;

namespace readifyknockknock.test
{
    public class FibonacciServiceTest
    {
        public FibonacciServiceTest()
        {
            service = new FibonacciService();
        }

        [Fact]
        public void TestCalculate_Normal()
        {
            Assert.Equal(1, service.Calculate(1));
            Assert.Equal(1, service.Calculate(2));
            Assert.Equal(2, service.Calculate(3));
            Assert.Equal(3, service.Calculate(4));
            Assert.Equal(5, service.Calculate(5));
            Assert.Equal(8, service.Calculate(6));
            Assert.Equal(13, service.Calculate(7));
            Assert.Equal(21, service.Calculate(8));
            Assert.Equal(34, service.Calculate(9));
            Assert.Equal(55, service.Calculate(10));
        }

        [Fact]
        public void TestCalculate_Negative()
        {
            Assert.Equal(1, service.Calculate(-1));
            Assert.Equal(-1, service.Calculate(-2));
            Assert.Equal(2, service.Calculate(-3));
            Assert.Equal(-3, service.Calculate(-4));
            Assert.Equal(5, service.Calculate(-5));
            Assert.Equal(-8, service.Calculate(-6));
            Assert.Equal(13, service.Calculate(-7));
            Assert.Equal(-21, service.Calculate(-8));
            Assert.Equal(34, service.Calculate(-9));
            Assert.Equal(-55, service.Calculate(-10));
        }

        // [Fact]
        // public void TestCalculate_BigNumber()
        // {
        //     Assert.Equal(7540113804746346000, service.Calculate(92));
        // }

        [Fact]
        public void TestCalculate_NegativeBigNumber()
        {
          CalculateWithException(n: -93, expectException: true);
; 
        }

        [Fact]
        public void TestCalculate_PositiveBigNumber()
        {
            CalculateWithException(n: 93, expectException: true);
;       }

        public void CalculateWithException(long n, bool expectException)
        {
            bool isException = false;
            try
            {
                var value = service.Calculate(n);
            }
            catch
            {
                isException = true;
            }
            Assert.Equal(expectException, isException);
        }

        #region Implementation
        
        FibonacciService service;

        #endregion
    }
}
