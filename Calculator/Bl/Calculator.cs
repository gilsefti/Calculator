using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Bl
{
    public class Calculator: ICalculator
    {
        OperationsFactory OperationsFactory;
        public Calculator(OperationsFactory operationsFactory) {
            this.OperationsFactory = operationsFactory;
        }
        public double Calculate(string excersize) {
            string operatorStr = "";
            foreach (var item in OperationsFactory.operationsDict)
            {
                if (excersize.Contains(item.Key))                
                    operatorStr = item.Key;                
            }
            var arr = excersize.Split(operatorStr);
            double a = Convert.ToDouble(arr[0]);
            double b = Convert.ToDouble(arr[1]);
            return Calculate(a, b, operatorStr);
        }
        public double Calculate(double a, double b, string operation)
        {
            IOperator operarte = OperationsFactory.OperatorFactory(operation);
           return operarte.Calculate(a, b);
            
           // IOperator operator = OperatorFactory(operation);
           //return operator.
        }
       
        
    }
}
