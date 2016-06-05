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
        private const double _t = 1d;
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
            var balance401k = _input.Current401kBalance;
            var balanceIra = _input.CurrentIraBalance;
            var interestRateAnnual401k = Convert.ToDouble(_input.InterestRateAnnual401k);
            var interestRateAnnualIra = Convert.ToDouble(_input.InterestRateAnnualIra);
            
            for (int i = 0; i <= _input.YearsUntilRetirement; i++)
            {
                var paycheckBuilder = new PaycheckBuilder(_numberOfPaychecksPerYear, grossPerPaycheck, _input.EmployeeContributionPercent);
                var annualStatement = new AnnualStatement(paycheckBuilder.GetAll());

                results.Add(new CalculatorResult()
                {
                    Year = i,
                    AnnualSalaryBase = annualStatement.AnnualSalaryBase,
                    AnnualBonus = annualStatement.Bonus,
                    AnnualSalary = annualStatement.AnnualSalary,
                    EmployeeContributions = annualStatement.EmployeeContribution,
                    Employer401KMatch = annualStatement.EmployerMatch,
                    EmployerRetirementContribution = annualStatement.RetirementContribution,
                    Balance401K = balance401k,
                    BalanceIra = balanceIra
                });

                // Make adjustments for next year.
                grossPerPaycheck = grossPerPaycheck + (grossPerPaycheck * _input.AnnualSalaryIncreasePercent);
                var total401k =  balance401k +
                                 annualStatement.EmployeeContribution +
                                 annualStatement.EmployerMatch +
                                 annualStatement.RetirementContribution;

                balance401k = CompoundInterestCalculator.CalculateAsDecimal(total401k, interestRateAnnual401k, 1, 1);
                balanceIra = CompoundInterestCalculator.CalculateAsDecimal(balanceIra, interestRateAnnualIra, 1, 1);
            }

            return new CalculatorOutput()
            {
                Results = results
            };
        }
    }
}