using System.Collections.Generic;
using Calculator.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class AnnualStatementShould
    {
        private decimal _grossPerPaycheck = 5000m;
        private decimal _employeeContributionPercent = .10m;
            

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
        [TestMethod]
        public void ReturnCorrectAnnualSalary()
        {
            // Arrange
            var paychecks = GetPaychecksForYear();
            var annualStatement = new AnnualStatement(paychecks);
            const int expected = 138000;

            // Act
            var actual = annualStatement.AnnualSalary;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        #region Helpers
        private Paycheck GetPaycheck()
        {
            return new Paycheck(_grossPerPaycheck, _employeeContributionPercent);
        }

        private List<Paycheck> GetPaychecksForYear()
        {
            var paychecks = new List<Paycheck>();
            var numberOfPaychecks = 24;
            for (int i = 1; i <= numberOfPaychecks; i++)
            {
                paychecks.Add(GetPaycheck());
            }
            var bonus = new Bonus(paychecks);
            paychecks.Add(new Paycheck(bonus.Value, _employeeContributionPercent, PaycheckType.Bonus));
            return paychecks;
        }
        #endregion
    }
}