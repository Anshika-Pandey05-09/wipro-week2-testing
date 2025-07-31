using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CaseStudy
{
    public class NotificationContext
    {
        private readonly INotificationStrategy _strategy;

        public NotificationContext(INotificationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Notify(string message)
        {
            _strategy.Send(message);
        }
    }
}
