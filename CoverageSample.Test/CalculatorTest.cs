using Xunit;

namespace CoverageSample.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(55, new Calculator().Add(33, 22));
        }
    }
}
