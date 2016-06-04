using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class AnnualStatementShould
    {
        [TestMethod]
        public void ReturnCorrectAnnualSalaryBase()
        {
            // Arrange
            var paychecks = GetPaychecksForYear();
            var annualStatement = new AnnualStatement(paychecks);
            const int expected = 120000;
            
            // Act
            var actual = annualStatement.AnnualSalaryBase;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReturnCorrectBonus()
        {
            // Arrange
            var paychecks = GetPaychecksForYear();
            var annualStatement = new AnnualStatement(paychecks);
            const int expected = 18000;

            // Act
            var actual = annualStatement.Bonus;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #region Helpers
        private Paycheck GetPaycheck()
        {
            var grossPerPaycheck = 5000m;
            var employeeContributionPercent = .10m;
            return new Paycheck(grossPerPaycheck, employeeContributionPercent);
        }

        private List<Paycheck> GetPaychecksForYear()
        {
            var paychecks = new List<Paycheck>();
            var numberOfPaychecks = 24;
            for (int i = 1; i <= numberOfPaychecks; i++)
            {
                paychecks.Add(GetPaycheck());
            }
            return paychecks;
        }
        #endregion
    }
}