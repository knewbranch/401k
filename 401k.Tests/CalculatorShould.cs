using System.Linq;
using Calculator.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnCorrectAnnualSalaryBaseForYear1()
        {
            // Arrange
            var input = GetCalculatorInput();
            const decimal expectedAnnualSalary = 153126.00m;

            // Act
            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            var actualAnnualSalary = output.Results.Single(x => x.Year == 1).AnnualSalaryBase;

            // Assert
            Assert.AreEqual(expectedAnnualSalary, actualAnnualSalary);
        }

        [TestMethod]
        public void ReturnCorrectBonusForYear1()
        {
            // Arrange
            var input = GetCalculatorInput();
            const decimal expectedBonus = 22968.90m;

            // Act
            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            var actualBonus = output.Results.Single(x => x.Year == 1).AnnualBonus;

            // Assert
            Assert.AreEqual(expectedBonus, actualBonus);
        }

        [TestMethod]
        public void ReturnCorrectAnnualSalaryForYear1()
        {
            // Arrange
            var input = GetCalculatorInput();
            const decimal expectedAnnualSalary = 176094.90m;

            // Act
            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            var actualAnnualSalary = output.Results.Single(x => x.Year == 1).AnnualSalary;

            // Assert
            Assert.AreEqual(expectedAnnualSalary, actualAnnualSalary);
        }
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
                InterestRateAnnual = .06m,
                PaychecksPerYear = 24,
                RetirementContributionPercentMonthly = .04m,
                YearsUntilRetirement = 22
            };
        }
    }
}
