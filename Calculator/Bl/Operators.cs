using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Bl
{
    public class Mult : IOperator
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
    public class Plus : IOperator
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
    public class Minus : IOperator
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
    public class Devide : IOperator
    {
        public double Calculate(double a, double b)
        {
            return a / b;
        }
    }
}
