using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Notification_System_DP.Interfaces;
using Notification_System_DP.Observers;

namespace Notification_System_DP.Models
{
        public class User : ISubscriber
        {
            public string Email { get; }
            public string PhoneNumber { get; }
            public bool IsSubscribed { get; private set; }
            private ISubject Subject { get; }

            public User(string email, string phoneNumber, ISubject subject)
            {
                Email = email;
                PhoneNumber = phoneNumber;
                Subject = subject;
            }

            public void Subscribe()
            {
                // Logic to subscribe user
                IsSubscribed = true;
                Subject.Attach(new UserObserver(this));
            }

            public void Unsubscribe()
            {
                // Logic to unsubscribe user
                IsSubscribed = false;
                Subject.Detach(new UserObserver(this));
            }
        }
    }






