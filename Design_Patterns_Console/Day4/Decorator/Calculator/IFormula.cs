using System;
namespace Design_Patterns_Console.Day4.Decorator.Calculator
{
    public interface IFormula
    {
        string GetFormula();
        double GetResult();
    }
}
