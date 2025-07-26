using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SmsSender
    {
        public void SendSms(string phoneNumber, string message)
        {
            Console.WriteLine($"SMS sent to {phoneNumber}: {message}");
        }
    }
}
