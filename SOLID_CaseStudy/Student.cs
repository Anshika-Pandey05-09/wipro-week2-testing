using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CaseStudy
{
    public class Student : User
    {
        public override void AccessPortal()
        {
            Console.WriteLine("Access granted to Student Dashboard.");
        }
    }
}
