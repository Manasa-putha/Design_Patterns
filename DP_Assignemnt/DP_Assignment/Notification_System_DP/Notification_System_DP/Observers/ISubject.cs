using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification_System_DP.Interfaces;

namespace Notification_System_DP.Observers
{
    public interface ISubject
        {
            void Attach(IObserver observer);
            void Detach(IObserver observer);
            void Notify();
        }
    }
