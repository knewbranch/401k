using System.Collections.Generic;
using Calculator.Enums;

namespace Calculator
{
    public class PaycheckBuilder
    {
        private readonly int _numberOfPaychecks;
        private readonly decimal _grossPerPaycheck;
        private readonly decimal _employeeContributionPercent;
        private List<Paycheck> _paychecks;
        
        public PaycheckBuilder(int numberOfPaychecks, decimal grossPerPaycheck, decimal employeeContributionPercent)
        {
            _numberOfPaychecks = numberOfPaychecks;
            _grossPerPaycheck = grossPerPaycheck;
            _employeeContributionPercent = employeeContributionPercent;
            BuildPaychecks();
        }

        private void BuildPaychecks()
        {
            _paychecks = new List<Paycheck>();
            for (int i = 1; i <= _numberOfPaychecks; i++)
            {
                _paychecks.Add(new Paycheck(_grossPerPaycheck, _employeeContributionPercent, PaycheckType.Regular));
            }

            var bonus = new Bonus(_paychecks);
            _paychecks.Add(new Paycheck(bonus.Value, _employeeContributionPercent, PaycheckType.Bonus));
        }

        public List<Paycheck> GetAll()
        {
            return _paychecks;
        } 
    }
}