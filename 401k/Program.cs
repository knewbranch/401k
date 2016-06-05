using System;
using Calculator.Messages;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           var input = new CalculatorInput()
            {
                AnnualBonusPercentage = .015m,
                GrossPerPaycheck = 6380.25m,
                AnnualSalaryIncreasePercent = .03m,
                Current401kBalance = 60000,
                CurrentIraBalance = 207000,
                EmployeeContributionPercent = .10m,
                EmployerMatchMaxPercentPerPaycheck = .06m,
                InterestRateAnnual401k = .06m,
                InterestRateAnnualIra = .06m,
                PaychecksPerYear = 24,
                RetirementContributionPercentMonthly = .04m,
                YearsUntilRetirement = 22
            };

            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            foreach (var result in output.Results)
            {
                Console.WriteLine(result.ToString());
            }
            Console.ReadKey();
        }
    }
}
