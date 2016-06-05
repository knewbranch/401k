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
            sb.AppendLine(string.Format("Base Salary: {0:C}", AnnualSalaryBase));
            sb.AppendLine(string.Format("Bonus: {0:C}", AnnualBonus));
            sb.AppendLine(string.Format("Total Annual Salary: {0:C}", AnnualSalary));
            sb.AppendLine(string.Format("Employee Contributions: {0:C}", EmployeeContributions));
            sb.AppendLine(string.Format("Employee 401K Match: {0:C}", Employer401KMatch));
            sb.AppendLine(string.Format("Employer Retirement Contribution: {0:C}", EmployerRetirementContribution));
            sb.AppendLine(string.Format("401K Balance: {0:C}", Balance401K));
            sb.AppendLine(string.Format("IRA Balance: {0:C}", BalanceIra));
            sb.AppendLine(string.Format("Total Retirement Balance: {0:C}", BalanceTotal));
            sb.AppendLine();
            return sb.ToString();
        }
    }
}