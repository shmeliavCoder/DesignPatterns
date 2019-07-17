using System;
namespace Design_Patterns_Console.Day4.FacadeAndProxy
{
    public class FlightSystemFacade : ICustomer, ICompany, IAdmin
    {
        FlightDAO flightDAO;

        public FlightSystemFacade()
        {
            flightDAO = new FlightDAO();
        }

        public void BuyTicket()
        {
            flightDAO.InsertTicket();
        }

        public void CreateCompany()
        {
            flightDAO.InsertCompany();
        }

        public void CreateCustomer()
        {
            flightDAO.InsertCustomer();
        }

        public void ShowMyTickets()
        {
            flightDAO.GetTickets();
        }

        void ICompany.CancelFlight()
        {
            flightDAO.RemoveFlight();
        }

        void ICompany.CreateFlight()
        {
            flightDAO.InsertFlight();
        }
    }
}
