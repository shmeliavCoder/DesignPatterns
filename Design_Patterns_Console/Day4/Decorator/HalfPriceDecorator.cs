using System;
namespace Decorator
{
    public class HalfPriceDecorator : ToppingDecoratorBase
    {
        public HalfPriceDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " half price";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() / 2;
        }
    }
}