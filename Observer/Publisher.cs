using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher
    {
        private readonly List<ISubscriber> _subscribers = new ();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify(string context)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(context);
            }
        }
    }
}
