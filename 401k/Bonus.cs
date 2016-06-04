using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Bonus
    {
        private readonly List<Paycheck> _paychecksForYear;
        
        public Bonus(List<Paycheck> paychecksForYear)
        {
            _paychecksForYear = paychecksForYear;
        }

        public decimal Value
        {
            get
            {
                var totalGrossPay = _paychecksForYear.Sum(x => x.GrossPay);
                var bonusPercentage = .15m;
                return totalGrossPay * bonusPercentage;
            }
        }
    }
}