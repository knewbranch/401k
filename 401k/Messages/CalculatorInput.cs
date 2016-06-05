namespace Calculator.Messages
{
    public class CalculatorInput
    {
        public decimal GrossPerPaycheck { get; set; }
        public int PaychecksPerYear { get; set; }
        public decimal EmployeeContributionPercent { get; set; }
        public decimal EmployerMatchMaxPercentPerPaycheck { get; set; }
        public decimal AnnualSalaryIncreasePercent { get; set; }
        public decimal AnnualBonusPercentage { get; set; }
        public decimal RetirementContributionPercentMonthly { get; set; }
        public decimal Current401kBalance { get; set; }
        public decimal CurrentIraBalance { get; set; }
        public int YearsUntilRetirement { get; set; }
        public decimal InterestRateAnnual401k { get; set; }
        public decimal InterestRateAnnualIra { get; set; }
    }
}