using Xunit;

namespace xUnitProject
{
    public class CalculatorTests
    {
        private readonly Calculator _sut; // sut = System Under Test
        public CalculatorTests()
        {
            _sut = new Calculator();
        }
        [Fact]
        public void AddTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Add(5);
            _sut.Add(8);
            Assert.Equal(13,_sut.Value);
        }
    }
}