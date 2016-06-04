using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class PaycheckShould
    {
        [TestMethod]
        public void ReturnCorrectEmployeeContributionsPerPaycheck()
        {
            // Arrange
            var paycheck = GetPaycheck();
            const decimal expected = 638.025m;

            // Act
            var actual = paycheck.EmployeeContribution;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnCorrectEmployerMatch()
        {
            // Arrange
            var paycheck = GetPaycheck();
            var expected = 191.4075m;

            // Act
            var actual = paycheck.EmployerMatch;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReturnCorrectPretaxMatch()
        {
            // Arrange
            var paycheck = GetPaycheck();
            var expected = 382.815m;

            // Act
            var actual = paycheck.PretaxMatch;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReturnCorrectPretaxUnmatched()
        {
            // Arrange
            var paycheck = GetPaycheck();
            var expected = 255.21m;

            // Act
            var actual = paycheck.PretaxUnmatched;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private Paycheck GetPaycheck()
        {
            var grossPerPaycheck = 6380.25m;
            var employeeContributionPercent = .10m;
            return new Paycheck(grossPerPaycheck, employeeContributionPercent);
        }
    }
}