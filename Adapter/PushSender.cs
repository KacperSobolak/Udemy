using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PushSender : INotificationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending push notification to {userId} Title: {notification.Title}, Body: {notification.Body}");
        }
    }
}
