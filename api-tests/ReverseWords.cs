using System;
using Xunit;
using api.Service;

namespace readifyknockknock.test
{
    public class ReverseWordsServiceTest
    {
        [Fact]
        public void TestCalculate()
        {
            var service = new ReverseWords();
            Assert.Equal("cba fed ihg lkj", service.Calculate("abc def ghi jkl"));
        }
    }
}
