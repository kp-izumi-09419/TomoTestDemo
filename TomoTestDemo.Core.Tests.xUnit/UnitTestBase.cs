using Xunit.Abstractions;

namespace TomoTestDemo.Core.Tests.XUnit
{
    public abstract class UnitTestBase
    {
        protected ITestOutputHelper _testOutputHelper = null;

        public UnitTestBase(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
    }
}