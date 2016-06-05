using Calculator.Enums;

namespace Calculator
{
    public class Paycheck
    {
        private readonly decimal _grossPay;
        private readonly decimal _employeeContributionPercent;
        private decimal _employerMatchMaxPercent = .06m;

        public Paycheck(decimal grossPay, decimal employeeContributionPercent, PaycheckType type)
        {
            _grossPay = grossPay;
            _employeeContributionPercent = employeeContributionPercent;
            Type = type;
        }
        public Paycheck(decimal grossPay, decimal employeeContributionPercent)
        {
            _grossPay = grossPay;
            _employeeContributionPercent = employeeContributionPercent;
            Type = PaycheckType.Regular;
        }

        public decimal EmployeeContribution
        {
            get { return _grossPay * _employeeContributionPercent; }
        }
        public decimal EmployerMatch
        {
            get{return Half(_grossPay * _employerMatchMaxPercent);}
        }
        public decimal PretaxMatch
        {
            get { return _grossPay * _employerMatchMaxPercent; }
        }
        public decimal PretaxUnmatched
        {
            get { return EmployeeContribution - PretaxMatch; }
        }
        public decimal GrossPay
        {
            get { return _grossPay; }
        }
        public PaycheckType Type { get; private set; }

        private decimal Half(decimal input)
        {
            return input * .5m;
        }
    }
}