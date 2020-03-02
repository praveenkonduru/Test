using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = 2 + 2;
            Assert.Equal(5, x);
        }

        [Fact]
        public void Test2()
        {
            var test = false;
            Assert.True(test);
        }
    }
}
