namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationSender notificationSender = new EmailSender();
            Notification notification = new Notification
            {
                Title = "Welcome",
                Body = "Thank you for registering!"
            };
            notificationSender.SendNotification(1, notification);

            notificationSender = new SmsSenderAdapter();
            notificationSender.SendNotification(2, notification);
        }
    }
}
