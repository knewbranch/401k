using System.Collections.Generic;

namespace Calculator.Messages
{
    public class CalculatorOutput
    {
        public CalculatorOutput()
        {
            Results = new List<CalculatorResult>();
        }

        public List<CalculatorResult> Results { get; set; }  
    }
}