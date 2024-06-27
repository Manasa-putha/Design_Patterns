using Notification_System_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_DP.Interfaces
{
    public interface INotification
        {
            void SendNotification(string subject, string messageBody);
        }
}

