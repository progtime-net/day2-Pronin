using CalcJun.Interfaces;
using CalcJun.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcJun
{
    public class Calculator : ICalculator
    {
        private List<IOperation> operations = new List<IOperation>()
        {
            new OperationMinus(), new OperationPlus(), new OperationDev(), new OperationYmn()
        };
        public void InputAndCalculate()
        {
            Console.Write("Ваш пример: ");
            string task = Console.ReadLine();

            string operation = task.Split()[1];
            float a = float.Parse(task.Split()[0]);
            float b = float.Parse(task.Split()[2]);
            
            Console.WriteLine($"Ваш результат: {ExecuteOperation(operation, a, b)}");
        }

        public float ExecuteOperation(string operation, float a, float b)
        {
            foreach (IOperation op in operations)
            {
                if (op.Name == operation)
                {
                    return op.Execute(a, b);
                }
            }
            return 0;
        }
    }
}
