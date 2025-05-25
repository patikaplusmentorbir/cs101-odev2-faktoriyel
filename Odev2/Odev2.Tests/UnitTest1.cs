using Xunit;
using Odev2;

namespace Odev2.Tests
{
    public class OdevTest
    {
        [Fact]
        public void TestFactorial()
        {
            Assert.Equal(1, Odev.Factorial(0));
            Assert.Equal(1, Odev.Factorial(1));
            Assert.Equal(2, Odev.Factorial(2));
            Assert.Equal(6, Odev.Factorial(3));
            Assert.Equal(24, Odev.Factorial(4));
            Assert.Equal(120, Odev.Factorial(5));
        }
    }
}
