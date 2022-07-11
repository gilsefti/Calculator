using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Bl
{
   public interface IOperator
    {
        public double Calculate(double a, double b);
    }
}
