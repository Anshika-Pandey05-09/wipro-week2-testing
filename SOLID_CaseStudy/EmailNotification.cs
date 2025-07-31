using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CaseStudy
{
    public class EmailNotification : INotificationStrategy
    {
        public void Send(string message)
        {
            Console.WriteLine($"[EMAIL] {message}");
        }
    }
}
