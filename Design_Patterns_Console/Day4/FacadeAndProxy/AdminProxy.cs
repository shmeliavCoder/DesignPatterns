using System;
namespace Design_Patterns_Console.Day4.FacadeAndProxy
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public AdminProxy()
        {
        }

        public void CreateCompany()
        {
            Console.WriteLine("Company created");
        }

        public void CreateCustomer()
        {
            Console.WriteLine("Customer created");
        }
    }
}
