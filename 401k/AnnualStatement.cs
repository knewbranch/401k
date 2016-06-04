using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Calculator
{
    public class AnnualStatement
    {
        private readonly List<Paycheck> _paychecks;
        private readonly Bonus _bonus;
        private readonly RetirementFund _retirementFund;
        
        public AnnualStatement(List<Paycheck> paychecks)
        {
            _paychecks = paychecks;
            _bonus = new Bonus(paychecks);
        }

        public decimal AnnualSalary
        {
            get
            {
                return AnnualSalaryBase + Bonus;
            }
        }
        public decimal AnnualSalaryBase
        {
            get
            {
                return _paychecks.Sum(x => x.GrossPay);
            }
        }
        public decimal Bonus
        {
            get { return _bonus.Value; }
        }
        public decimal EmployeeContribution
        {
            get { return _paychecks.Sum(x => x.EmployeeContribution); }
        }
        public decimal EmployerMatch
        {
            get { return _paychecks.Sum(x => x.EmployerMatch); }
        }
        public decimal PretaxMatch
        {
            get { return _paychecks.Sum(x => x.PretaxMatch); }
        }
        public decimal PretaxUnmatched
        {
            get { return _paychecks.Sum(x => x.PretaxUnmatched); }
        }
        public decimal RetirementContribution
        {
            get { return 0; }
        }
    }
}