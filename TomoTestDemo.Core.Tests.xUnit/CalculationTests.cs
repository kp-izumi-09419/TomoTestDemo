using System.Collections.Generic;
using System.Linq;

using TomoTestDemo.Core.Models;
using TomoTestDemo.Core.Tests.XUnit;

using Xunit;
using Xunit.Abstractions;

namespace TomoTestDemo.Core.Tests.xUnit
{
    public class CalculationTests : UnitTestBase
    {
        private readonly ICalculation _calculation;

        public CalculationTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            _calculation = new Calculation();
        }

        [Fact]
        public void 演算タイプ()
        {
            var expected = new List<string>
            {
                "＋",
                "－",
                "×",
                "÷"
            }.AsEnumerable();

            Assert.Equal(expected, _calculation.Symbols);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 2, 12)]
        public void 足し算(int left, int right, int expected)
        {
            var result = _calculation.Add(left, right);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        public void 引き算(int left, int right, int expeced)
        {
            var result = _calculation.Subtraction(left, right);

            Assert.Equal(expeced, result);
        }

        [Theory]
        [InlineData("＋", 1, 1, 2)]
        [InlineData("－", 5, 2, 3)]
        public void 四則演算(string calcType, int left, int right, int expected)
        {
            var result = _calculation.Run(calcType, left, right);

            Assert.Equal(expected, result);
        }
    }
}