using Xunit;
using Xunit.Abstractions;

namespace xUnitProject
{
    public class GuidGeneratorTests
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTests(ITestOutputHelper output)
        {
            _guidGenerator = new GuidGenerator();
            _output = output;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }
        
        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }
    }
    public class GuidGeneratorTestsTwo
    {
        
    }
}