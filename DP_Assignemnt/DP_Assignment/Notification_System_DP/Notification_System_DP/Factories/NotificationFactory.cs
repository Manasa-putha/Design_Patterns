using Notification_System_DP.Interfaces;
using Notification_System_DP.Notifications;
using Notification_System_DP.Notifications.Notification_System_DP.Notifications;

namespace Notification_System_DP.Factories
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(NotificationChannel channel)
        {
            switch (channel)
            {
                case NotificationChannel.Email:
                    return new EmailNotification();
                case NotificationChannel.SMS:
                    return new SMSNotification();
                default:
                    throw new NotSupportedException("Unsupported notification channel");
            }
        }
    }
}

