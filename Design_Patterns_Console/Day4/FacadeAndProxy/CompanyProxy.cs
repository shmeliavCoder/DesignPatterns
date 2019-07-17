using System;
namespace Design_Patterns_Console.Day4.FacadeAndProxy
{
    public class CompanyProxy : ClientProxy , ICompany
    {
        public CompanyProxy()
        {
        }

        public void CancelFlight()
        {
            Console.WriteLine("Flight Canceled");
        }

        public void CreateFlight()
        {
            Console.WriteLine("Create Flight");
        }
    }
}
