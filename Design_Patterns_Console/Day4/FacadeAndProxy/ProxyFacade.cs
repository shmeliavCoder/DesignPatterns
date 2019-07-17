using System;
namespace Design_Patterns_Console.Day4.FacadeAndProxy
{
    public class ProxyFacade
    {
        public ProxyFacade()
        {
        }

        public ClientProxy Login(string username, string password)
        {
            if (username=="admin" || username == "administrator")
            {
                return new AdminProxy();
            }
            else if (username == "customer")
            {
                return new CustomerProxy();
            }
            else if (username == "company")
            {
                return new CompanyProxy();
            }

            throw new Exception("not a real user");
        }

    }
}
