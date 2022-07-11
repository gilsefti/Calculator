using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Bl
{
    public class ColorCalculatorDecorator 
    {
        ICalculator Calculator;
        public ColorCalculatorDecorator(ICalculator calculator) {
            this.Calculator = calculator;
        }
        public (double,string) Calculate(double a, double b, string operation)
        {
           double result = Calculator.Calculate( a,  b,  operation);
            return (result, "color");//you need to calculate color based on result value.
        }
    }
}
