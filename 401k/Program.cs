using System;
using Calculator.Messages;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPaychecks = 24;
            var employerMatch = .03d;
            var employerMatchMax = .06d;
            var annualSalary = 153000d;
            var annualSalaryIncrease = .03d;
            var bonus = 23000d;
            var retirementContributionPercentage = .04d;
            var employeeContributionPercentage = .10d;
            var current401kBalance = 60000d;
            var currentIraBalance = 207000d;
            var yearsUntilRetirement = 22;
           

           
            var interestRate = .06d;
            var annualCompoundInterest = 1d;
            var t = 1d;

            var input = new CalculatorInput()
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

            var calculator = new Calculator(input);
            var output = calculator.Calculate();
            foreach (var result in output.Results)
            {
                Console.WriteLine(result.ToString());
            }
            
            //for (int i = 1; i <= yearsUntilRetirement; i++)
            //{
            //    var grossPerPaycheck = annualSalary / numberOfPaychecks;
            //    var retirementContributionPerMonth = (grossPerPaycheck * 2) * retirementContributionPercentage;
            //    var employeeContributionPerPaycheck = grossPerPaycheck * employeeContributionPercentage;
            //    var employerContributionPerPaycheck = (grossPerPaycheck * employerMatchMax) / 2;
            //    var pretaxMatch = grossPerPaycheck * employerMatchMax;
            //    var pretaxUnmatched = employeeContributionPerPaycheck - pretaxMatch;

            //    Console.WriteLine("grossPerPaycheck: {0:C}", grossPerPaycheck);
            //    Console.WriteLine("employeeContributionPerPaycheck: {0:C}", employeeContributionPerPaycheck);
            //    Console.WriteLine("employerContributionPerPaycheck: {0:C}", employerContributionPerPaycheck);
            //    Console.WriteLine("retirementContributionPerMonth: {0:C}", retirementContributionPerMonth);
            //    Console.WriteLine("pretaxMatch: {0:C}", pretaxMatch);
            //    Console.WriteLine("pretaxUnmatched: {0:C}", pretaxUnmatched);

            //    var monthsInYear = 12;
            //    var employeeContributionPerYear = employeeContributionPerPaycheck * numberOfPaychecks;
            //    var employerContributionPerYear = employerContributionPerPaycheck * numberOfPaychecks;
            //    var retirementContributionPerYear = retirementContributionPerMonth * monthsInYear;
            //    var total401k =    current401kBalance +
            //                       employeeContributionPerYear +
            //                       employerContributionPerYear +
            //                       retirementContributionPerYear;


            //    current401kBalance = total401k * Math.Pow((1.0 + interestRate / annualCompoundInterest), (annualCompoundInterest * t));
                
            //    var iraInterestRate = .10;
            //    currentIraBalance = currentIraBalance * Math.Pow((1.0 + iraInterestRate / annualCompoundInterest), (annualCompoundInterest * t));

            //    Console.WriteLine("Year {0}; 401K Balance: {1:C}; IRA Balance: {2:C}; Total: {3:C}; Salary: {4:C}; EE Contributions: {5:C}", i, current401kBalance, currentIraBalance, current401kBalance + currentIraBalance, annualSalary, employeeContributionPerYear);
            //    annualSalary = annualSalary + (annualSalary * annualSalaryIncrease);
            //}

            Console.ReadKey();
        }
    }
}
