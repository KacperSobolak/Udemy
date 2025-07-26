using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new SmsSender();

        public void SendNotification(int userId, Notification notification)
        {
            string userNumber = null; //based on UserId
            _smsSender.SendSms(userNumber, $"Title: {notification.Title} Body: {notification.Body}");
        }
    }
}
