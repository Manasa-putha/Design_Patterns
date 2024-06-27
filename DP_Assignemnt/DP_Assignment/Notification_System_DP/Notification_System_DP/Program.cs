using System;
using System.Collections.Generic;
using Notification_System_DP.Models;
using Notification_System_DP.Notifications.Notification_System_DP.Notifications;
using Notification_System_DP.Observers;
using Notification_System_DP.Services;

namespace Notification_System_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create NotificationSubject
            NotificationSubject notificationSubject = new NotificationSubject();

            // Fetch users from database using Database class
            Database.Database database = new Database.Database();
            List<User> users = database.GetUsers(notificationSubject);

            // Subscribe users
            foreach (User user in users)
            {
                user.Subscribe();
            }

            // Prompt user for notification details
            Console.WriteLine("Select notification channel (1 for Email, 2 for SMS):");
            int channelChoice = int.Parse(Console.ReadLine());
            NotificationChannel channel = (NotificationChannel)(channelChoice - 1);

            Console.WriteLine("Enter subject:");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter message body:");
            string messageBody = Console.ReadLine();

            // Display notification details
            Console.WriteLine("\nNotification details:");
            Console.WriteLine("Channel: " + channel);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Message Body: " + messageBody);

            // Send notifications to subscribed users
            Console.WriteLine("\nSending notifications...");
            foreach (User user in users)
            {
                if (user.IsSubscribed)
                {
                    if (channel == NotificationChannel.Email)
                    {
                        Console.WriteLine($"Sending email to: {user.Email}");
                    }
                    else if (channel == NotificationChannel.SMS)
                    {
                        Console.WriteLine($"Sending SMS to: {user.PhoneNumber}");
                    }
                   
                }
            }

            // Send notifications outside the loop, after iterating over all users
            NotificationService.Instance.SendNotification(channel, subject, messageBody, users);
            // Display confirmation message
            Console.WriteLine("\nNotifications sent successfully!");
        }
    }
}
