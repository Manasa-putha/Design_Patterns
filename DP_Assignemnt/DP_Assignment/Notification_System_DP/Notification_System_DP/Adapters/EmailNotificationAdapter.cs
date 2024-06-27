using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification_System_DP.Adapters;

namespace Notification_System_DP.Adapters
{

    public class EmailNotificationAdapter : INotificationAdapter
    {
        public void SendNotification(string recipient, string subject, string message)
        {
            // Implement logic to send email notification for further modifications
        }
    }
}
