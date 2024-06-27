using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Notification_System_DP.Models;
using Notification_System_DP.Strategies;

namespace Notification_System_DP.Strategies
{
   public class EmailNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string subject, string message, List<User> users)
        {
            // Implement logic to send email notifications to subscribed users
            Console.WriteLine("Sending email notifications...");
            foreach (var user in users)
            {
                Console.WriteLine($"Sending email to {user.Email}...");
                // Logic to send email notification
            }
            Console.WriteLine("Email notifications sent successfully!");
        }
    }
}
