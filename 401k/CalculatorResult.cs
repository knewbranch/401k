using System;
using System.Text;

namespace Calculator
{
    public class CalculatorResult
    {
        public decimal Balance401K { get; set; }
        public decimal BalanceIra { get; set; }
        public decimal BalanceTotal { get { return Balance401K + BalanceIra; } }
        public decimal AnnualSalary { get; set; }
        public decimal AnnualBonus { get; set; }
        public decimal AnnualSalaryBase { get; set; }
        public int Year { get; set; }
        public decimal EmployeeContributions { get; set; }
        public decimal Employer401KMatch { get; set; }
        public decimal EmployerRetirementContribution { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("Year: {0} ({1})", Year, DateTime.Now.AddYears(Year).Year));
            sb.AppendLine("===========================");
            sb.AppendLine(string.Format("Annual Salary Base: {0:C}", AnnualSalaryBase));
            sb.AppendLine(string.Format("Annual Salary: {0:C}", AnnualSalary));
            sb.AppendLine(string.Format("Annual Bonus: {0:C}", AnnualBonus));
            sb.AppendLine();
            return sb.ToString();
        }
    }
}