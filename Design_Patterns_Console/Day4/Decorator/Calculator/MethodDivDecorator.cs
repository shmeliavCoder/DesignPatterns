﻿using System;
namespace Design_Patterns_Console.Day4.Decorator.Calculator
{
    public class MethodDivDecorator : MethodDecoratorBase
    {
        double number { get; set; }

        public MethodDivDecorator(IFormula forumla, double number) : base(forumla)
        {
            this.number = number;
        }

        public override string GetFormula()
        {
            return $"{formula.GetFormula()} / {this.number}";
        }

        public override double GetResult()
        {
            return formula.GetResult() / this.number;
        }
    }
}
