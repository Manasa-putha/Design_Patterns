using System;
using System.Collections.Generic;
using Notification_System_DP.Factories;
using Notification_System_DP.Interfaces;
using Notification_System_DP.Models;

using Notification_System_DP.Notifications;
using Notification_System_DP.Notifications.Notification_System_DP.Notifications;

namespace Notification_System_DP.Services
{
    public class NotificationService
    {
        private static NotificationService instance;

        private NotificationService() { }

        public static NotificationService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationService();
                }
                return instance;
            }
        }

        public void SendNotification(NotificationChannel channel, string subject, string messageBody, List<User> users)
        {
            INotification notification = NotificationFactory.CreateNotification(channel);
            foreach (User user in users)
            {
                if (user.IsSubscribed)
                {
                    notification.SendNotification(subject, messageBody);
                }
            }
        }
    }
}
