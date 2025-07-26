using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface INotificationSender
    {
        void SendNotification(int userId, Notification notification);
    }
}
