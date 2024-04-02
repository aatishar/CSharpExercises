using Xunit;

namespace TaxCalculator.Tests
{

    public class TaxCalculatorTests
    {
        private TaxCalculator _taxCalculator;

        public TaxCalculatorTests()
        {
            _taxCalculator = new TaxCalculator();
        }

        [Theory]
        [InlineData(20_000, 1_111.04)]
        [InlineData(31_000, 2_514.00)]
        [InlineData(41_000, 5_214.00)]
        [InlineData(90_000, 19_157.13)]
        [InlineData(200_000, 60_634.89)]
        public void Should_Calculate_Tax(decimal salary, decimal expectedTotalTax)
        {
            var totalTax = Math.Round(_taxCalculator.Calculate(salary), 2);

            Assert.Equal(expectedTotalTax, totalTax);
        }
    }
}
