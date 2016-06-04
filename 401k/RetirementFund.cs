using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class RetirementFund
    {
        private readonly List<Paycheck> _paychecks;
        private decimal _contributionPercent = .04m;

        public RetirementFund(List<Paycheck> paychecks)
        {
            _paychecks = paychecks;
        }

        public decimal Contribution
        {
            get
            {
                var gross = _paychecks.Sum(x => x.GrossPay);
                return gross * _contributionPercent;
            }
        }
    }
}