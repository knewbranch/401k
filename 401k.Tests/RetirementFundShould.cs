using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class RetirementFundShould
    {
        [TestMethod]
        public void ReturnCorrectRetirementContributionPerMonth()
        {
            // Arrange
            var paycheck1 = GetPaycheck();
            var paycheck2 = GetPaycheck();
            var paychecks = new List<Paycheck>()
            {
                paycheck1,
                paycheck2
            };
            var retirementFund = new RetirementFund(paychecks);
            var expected = 510.42m;

            // Act
            var actual = retirementFund.Contribution;

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