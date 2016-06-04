namespace Calculator
{
    public class Paycheck
    {
        private readonly decimal _grossPay;
        private readonly decimal _employeeContributionPercent;
        private decimal _employerMatchMaxPercent = .06m;

        public Paycheck(decimal grossPay, decimal employeeContributionPercent)
        {
            _grossPay = grossPay;
            _employeeContributionPercent = employeeContributionPercent;
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
        private decimal Half(decimal input)
        {
            return input * .5m;
        }
    }
}