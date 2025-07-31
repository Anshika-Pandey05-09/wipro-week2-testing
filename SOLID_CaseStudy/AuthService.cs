using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CaseStudy
{
    public class AuthService
    {
        public bool Authenticate(string username, string password)
        {
            Console.WriteLine("Authenticating user...");
            if (username == "admin" && password == "admin123")
            {
                Console.WriteLine("Login successful.");
                return true;
            }

            Console.WriteLine("Invalid credentials.");
            return false;
        }
    }
}
