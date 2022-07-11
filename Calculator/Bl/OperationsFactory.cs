using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Bl
{
    public class OperationsFactory
    {
        public Dictionary<string, IOperator> operationsDict;
        Dictionary<string, int> operationsOrder;//I added dictionary for operations order.
        public OperationsFactory()
        {
            operationsDict = new Dictionary<string, IOperator>();
            operationsDict.Add("*", new Mult());
            operationsDict.Add("+", new Plus());
            operationsDict.Add("-", new Minus());
            operationsDict.Add("/", new Devide());
            //..You can add more like Power.
        }
        public IOperator OperatorFactory(string operation)
        {
            return operationsDict[operation];

        }
    }
}
