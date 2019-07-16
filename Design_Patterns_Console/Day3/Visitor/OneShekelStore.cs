using System;

namespace Visitor
{
    public class OneShekelStore : IVisitor
    {
        const double FIXED_PRICE =  1.0;

        public double Visit(Liquor liquor)
        {
            return FIXED_PRICE;
        }

        public double Visit(Tabacco tabacco)
        {
            return FIXED_PRICE;
        }

        public double Visit(Chocolate chocolate)
        {
            return FIXED_PRICE;
        }

        public double Visit(Perfume perfume)
        {
            return FIXED_PRICE;
        }

        public double Visit(ShopRent shopRent)
        {
            return FIXED_PRICE;
        }
    }
}