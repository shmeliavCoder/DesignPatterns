using System;
namespace Design_Patterns_Console.Day4.FacadeAndProxy
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public CustomerProxy()
        {
        }

        public void BuyTicket()
        {
            Console.WriteLine("Ticket Bought");
        }

        public void ShowMyTickets()
        {
            Console.WriteLine("Here are your tickets");
        }
    }
}
