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

        [Fact(Skip = "This test is obsolete")]
        public void AddTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Add(5);
            _sut.Add(8);
            Assert.Equal(13, _sut.Value);
        }

        [Fact(Skip = "This test is obsolete")]
        public void AddTwoNumbersShouldEqualTheirEqual2()
        {
            _sut.Add(3);
            _sut.Add(-3);
            Assert.Equal(0, _sut.Value);
        }

        [Theory]
        [InlineData(13,5,8)]
        [InlineData(0,-3,3)]
        [InlineData(0,0,0)]
        public void AddTwoNumbersShouldEqualTheirEqualTheory(decimal excepted, decimal firstToAdd, decimal secondToAdd)
        {
            _sut.Add(firstToAdd);
            _sut.Add(secondToAdd);
            Assert.Equal(excepted, _sut.Value);
        }
    }
}