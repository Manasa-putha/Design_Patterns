using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_DP.Adapters
{
    
        public interface INotificationAdapter
        {
            void SendNotification(string recipient, string subject, string message);
        }
    
}
