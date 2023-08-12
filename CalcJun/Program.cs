namespace CalcJun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Введите ваш пример по шаблону: 2 + 2");
            calculator.InputAndCalculate();
        }
    }
}