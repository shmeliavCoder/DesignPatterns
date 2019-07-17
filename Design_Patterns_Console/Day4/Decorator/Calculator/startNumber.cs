using System;
namespace Design_Patterns_Console.Day4.Decorator.Calculator
{
    public class StartNumber : IFormula
    {
        double number { get; set; }

        public StartNumber(double number)
        {
            this.number = number;
        }

        public string GetFormula()
        {
            return number.ToString();
        }

        public double GetResult()
        {
            return number;
        }
    }
}
