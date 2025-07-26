using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EmailSender : INotificationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending email notification to {userId} Title: {notification.Title}, Body: {notification.Body}");
        }
    }
}
