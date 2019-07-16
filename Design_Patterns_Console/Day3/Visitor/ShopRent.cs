using System;
namespace Visitor
{
    public class ShopRent : IVisitable
    {
        public ShopRent()
        {
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return "Check your rent price at your local visitor";
        }
    }
}
