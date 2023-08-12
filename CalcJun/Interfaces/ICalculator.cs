namespace CalcJun.Interfaces
{
    interface ICalculator
    {
        // 2 + 2
        // 4 / 2
        void InputAndCalculate();
        // operation - '+','-','/','*' 
        float ExecuteOperation(string operation, float a, float b);
    }
}
