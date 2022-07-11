using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Bl
{
  public  interface ICalculator
    {
        public double Calculate(double a, double b, string operation);
        public double Calculate(string excersize);
    }
}
