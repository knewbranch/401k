using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CompoundInterestCalculatorShould
    {
        [TestMethod]
        public void ShouldReturnCorrectValueAfterOneYear()
        {
            // Arrange
            double principal = 100000;
            double interestRate = .06d;
            int timesPerYear = 1;
            double years = 1;
            var expeted = 106000;

            // Act
            var actual = CompoundInterestCalculator.Calculate(principal, interestRate, timesPerYear, years);

            // Assert
            Assert.AreEqual(expeted, actual);
        }
        [TestMethod]
        public void ShouldReturnCorrectValueAfterTwoYears()
        {
            // Arrange
            double principal = 100000;
            double interestRate = .06d;
            int timesPerYear = 1;
            double years = 2;
            var expeted = 112360d;

            // Act
            var actual = CompoundInterestCalculator.Calculate(principal, interestRate, timesPerYear, years);

            // Assert
            Assert.AreEqual(expeted, actual);
        }
    }
}