using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification_System_DP.Adapters;
namespace Notification_System_DP.Facades
{
    public class NotificationFacade
    {
        private readonly INotificationAdapter _notificationAdapter;

        public NotificationFacade(INotificationAdapter notificationAdapter)
        {
            _notificationAdapter = notificationAdapter;
        }

        public void SendNotification(string recipient, string subject, string message)
        {
            // Implement any additional logic if needed
            _notificationAdapter.SendNotification(recipient, subject, message);
        }
    }
}
