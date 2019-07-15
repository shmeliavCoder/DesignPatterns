using System;

namespace ChainOfResp
{
    public class BillHandler500 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 500)
            {
                Console.WriteLine($"Giving 500 x {amount / 500} bills");
            }

            if (amount % 500 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 500);
                }
            }
        }
    }
}
