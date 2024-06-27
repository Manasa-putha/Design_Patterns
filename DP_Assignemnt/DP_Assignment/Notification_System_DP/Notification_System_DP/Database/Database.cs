using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Notification_System_DP.Models;
using Notification_System_DP.Observers;

namespace Notification_System_DP.Database
{
        public  class Database
        {
            public  List<User> GetUsers(ISubject subject)
            {
                // Mocked data
                List<User> users = new List<User>
            {
                new User("Manasa@example.com", "+1234567890", subject),
                new User("Ramu@example.com", "+91987654321", subject),
                new User("Raju@example.com", "+91987681231", subject)
            };

                return users;
            }
        }
}
