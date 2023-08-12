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
            IOperation oper = null;

            if (operation == "+")
            {
                oper = new OperationPlus();
            } 
            else if (operation == "-")
            {
                oper = new OperationMinus();
            }
            else if (operation == "/")
            {
                oper = new OperationDev();
            }
            else if (operation == "*") 
            {
                oper = new OperationYmn();
            }
            return oper.Execute(a, b);
        }
    }
}
