using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Notification_System_DP.Interfaces;
namespace Notification_System_DP.Observers
{

        public class NotificationSubject : ISubject
        {
            private List<IObserver> observers = new List<IObserver>();

            public void Attach(IObserver observer)
            {
                observers.Add(observer);
            }

            public void Detach(IObserver observer)
            {
                observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (var observer in observers)
                {
                    observer.Update();
                }
            }
        }
    }


