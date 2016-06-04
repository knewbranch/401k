using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Calculator.Messages;

namespace Calculator
{
    public class Calculator
    {
        private readonly CalculatorInput _input;
        private decimal _max401kContribution = 18000;
        private double _annualCompoundInterest = 1d;
        private decimal _monthsInYear = 12;
        private int _numberOfPaychecksPerYear = 24;

            
        public Calculator(CalculatorInput input)
        {
            _input = input;
        }

        public CalculatorOutput Calculate()
        {
            var results = new List<CalculatorResult>();

            var grossPerPaycheck = _input.GrossPerPaycheck;
            for (int i = 0; i <= _input.YearsUntilRetirement; i++)
            {
                var paycheck = new Paycheck(grossPerPaycheck, _input.EmployeeContributionPercent);
                var paycheckBuilder = new PaycheckBuilder(_numberOfPaychecksPerYear, paycheck);
                var annualStatement = new AnnualStatement(paycheckBuilder.GetPaychecksForYear());

                results.Add(new CalculatorResult()
                {
                    Year = i,
                    AnnualSalaryBase = annualStatement.AnnualSalaryBase,
                    AnnualBonus = annualStatement.Bonus,
                    AnnualSalary = annualStatement.AnnualSalary
                });

                grossPerPaycheck = grossPerPaycheck + (grossPerPaycheck * _input.AnnualSalaryIncreasePercent);

                //var monthsInYear = 12;
                //var employeeContributionPerYear = employeeContributionPerPaycheck * numberOfPaychecks;
                //var employerContributionPerYear = employerContributionPerPaycheck * numberOfPaychecks;
                //var retirementContributionPerYear = retirementContributionPerMonth * _monthsInYear;
                //var total401k = current401kBalance +
                //                   employeeContributionPerYear +
                //                   employerContributionPerYear +
                //                   retirementContributionPerYear;


                //current401kBalance = total401k * Math.Pow((1.0 + interestRate / _annualCompoundInterest), (_annualCompoundInterest * t));

                //var iraInterestRate = .10;
                //currentIraBalance = currentIraBalance * Math.Pow((1.0 + iraInterestRate / annualCompoundInterest), (annualCompoundInterest * t));

                //Console.WriteLine("Year {0}; 401K Balance: {1:C}; IRA Balance: {2:C}; Total: {3:C}; Salary: {4:C}; EE Contributions: {5:C}", i, current401kBalance, currentIraBalance, current401kBalance + currentIraBalance, annualSalary, employeeContributionPerYear);
                //annualSalary = annualSalary + (annualSalary * annualSalaryIncrease);
            }

            return new CalculatorOutput()
            {
                Results = results
            };
        }
    }
}