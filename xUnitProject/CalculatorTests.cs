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
        
        [Fact]
        public void AddTwoNumbersShouldEqualTheirEqual2()
        {
            _sut.Add(3);
            _sut.Add(-3);
            Assert.Equal(0,_sut.Value);
        }
    }
}