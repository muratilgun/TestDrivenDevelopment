using Xunit;
using Xunit.Abstractions;

namespace xUnitProject
{
    public class GuidGeneratorTests : IClassFixture<GuidGenerator>
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTests(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _output = output;
            _guidGenerator = guidGenerator;
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