using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification_System_DP.Interfaces;
using Notification_System_DP.Services;

namespace Notification_System_DP.Notifications
{
    public class EmailNotification : INotification
        {
            public void SendNotification(string subject, string messageBody)
            {
            // Implementation to send email notification
            Console.WriteLine($"Sending email notification : Subject - {subject}, Body - {messageBody}");
        }
        }
    }


