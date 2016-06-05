using System;

namespace Calculator
{
    public static class CompoundInterestCalculator
    {
        public static double Calculate(double principal, double interestRate, int timesPerYear, double years)
        {
            // (1 + r/n)
            double body = 1 + (interestRate / timesPerYear);

            // nt
            double exponent = timesPerYear * years;

            // P(1 + r/n)^nt
            return principal * Math.Pow(body, exponent);
        }

        public static decimal CalculateAsDecimal(decimal principal, double interestRate, int timesPerYear, double years)
        {
            return Convert.ToDecimal(Calculate(Convert.ToDouble(principal), interestRate, timesPerYear, years));
        }
    }
}