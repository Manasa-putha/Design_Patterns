using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification_System_DP.Interfaces;
using Notification_System_DP.Models;
namespace Notification_System_DP.Observers
{
   
  
        public class UserObserver : IObserver
        {
            private User user;

            public UserObserver(User user)
            {
                this.user = user;
            }

            public void Update()
            {
                // Logic to update user 
            }
        }
    }


