using System;
namespace Design_Patterns_Console.Day4.FacadeAndProxy
{
    public class FlightDAO
    {
        public FlightDAO()
        {
        }

        public void InsertTicket()
        {
            Console.WriteLine("Ticket inserted");
        }

        public void GetTickets()
        {
            Console.WriteLine("Here is your ticket");
        }

        public void InsertFlight()
        {
            Console.WriteLine("Flight inserted");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("Remove Flight");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("Customer inserted");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Company inserted");
        }
    }
}
