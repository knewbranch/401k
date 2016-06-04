using System.Collections.Generic;

namespace Calculator
{
    public class PaycheckBuilder
    {
        private readonly int _numberOfPaychecks;
        private readonly Paycheck _paycheck;

        public PaycheckBuilder(int numberOfPaychecks, Paycheck paycheck)
        {
            _numberOfPaychecks = numberOfPaychecks;
            _paycheck = paycheck;
        }

        public List<Paycheck> GetPaychecksForYear()
        {
            var paychecks = new List<Paycheck>();
            for (int i = 1; i <= _numberOfPaychecks; i++)
            {
                paychecks.Add(_paycheck);
            }
            return paychecks;
        } 
    }
}