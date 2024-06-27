using Notification_System_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_DP.Strategies
{
   public interface INotificationStrategy
        {
            void SendNotification(string subject, string message, List<User> users);
        }
}
