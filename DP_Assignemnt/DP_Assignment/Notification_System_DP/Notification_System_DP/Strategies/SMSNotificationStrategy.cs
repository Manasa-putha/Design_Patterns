using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Notification_System_DP.Models;
using Notification_System_DP.Strategies;

namespace Notification_System_DP.Strategies
{
    public class SMSNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string subject, string message, List<User> users)
        {
            // Implement logic to send SMS notifications to subscribed users
            Console.WriteLine("Sending SMS notifications...");
            foreach (var user in users)
            {
                Console.WriteLine($"Sending SMS to {user.PhoneNumber}...");
                // Logic to send SMS notification
            }
            Console.WriteLine("SMS notifications sent successfully!");
        }
    }
}
