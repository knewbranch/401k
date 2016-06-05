using System.Linq;
using Calculator.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnCorrectAnnualSalaryBaseForYear0()
        {
            // Arrange
            var input = GetCalculatorInput();
            const decimal expectedAnnualSalary = 153126.00m;

            // Act
            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            var actualAnnualSalary = output.Results.Single(x => x.Year == 0).AnnualSalaryBase;

            // Assert
            Assert.AreEqual(expectedAnnualSalary, actualAnnualSalary);
        }

        [TestMethod]
        public void ReturnCorrectBonusForYear0()
        {
            // Arrange
            var input = GetCalculatorInput();
            const decimal expectedBonus = 22968.90m;

            // Act
            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            var actualBonus = output.Results.Single(x => x.Year == 0).AnnualBonus;

            // Assert
            Assert.AreEqual(expectedBonus, actualBonus);
        }

        [TestMethod]
        public void ReturnCorrectAnnualSalaryForYear0()
        {
            // Arrange
            var input = GetCalculatorInput();
            const decimal expectedAnnualSalary = 176094.90m;

            // Act
            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            var actualAnnualSalary = output.Results.Single(x => x.Year == 0).AnnualSalary;

            // Assert
            Assert.AreEqual(expectedAnnualSalary, actualAnnualSalary);
        }


        #region Helpers
        private CalculatorInput GetCalculatorInput()
        {
            return new CalculatorInput()
            {
                AnnualBonusPercentage = .015m,
                GrossPerPaycheck = 6380.25m,
                AnnualSalaryIncreasePercent = .03m,
                Current401kBalance = 60000,
                CurrentIraBalance = 207000,
                EmployeeContributionPercent = .10m,
                EmployerMatchMaxPercentPerPaycheck = .06m,
                InterestRateAnnual401k = .06m,
                PaychecksPerYear = 24,
                RetirementContributionPercentMonthly = .04m,
                YearsUntilRetirement = 22
            };
        }
        #endregion
    }
}
