using System;
namespace Design_Patterns_Console.Day4.Decorator.Calculator
{
    public abstract class MethodDecoratorBase : IFormula
    {

        protected IFormula formula;

        public abstract string GetFormula();
        public abstract double GetResult();

        public MethodDecoratorBase(IFormula formula)
        {
            this.formula = formula;
        }
    }
}
