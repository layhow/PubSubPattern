using PubSubPattern.Abstract;
using PubSubPattern.Interface;
using System.Collections.Generic;

namespace PubSubPattern.Concrete
{
    public class MessageBroker : IMessageBroker
    {
        /// <summary>
        /// List to store all the subscriber
        /// </summary>
        private List<Subscriber> _subscribers = new List<Subscriber>();

        /// <summary>
        /// Add the subscriber into the list
        /// </summary>
        /// <param name="subscriber">subscriber for the data</param>
        public void Subscribe(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        /// <summary>
        /// Remove the subscriber remove the list. Do nothing if subscriber not found
        /// </summary>
        /// <param name="subscriber">subscriber to be remove</param>
        public void Unsubscribe(Subscriber subscriber)
        {
            // Do Nothing if not found
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
            }

        }

        /// <summary>
        /// Forward all the data to the subscriber.
        /// This could be enhance with topic subscription
        /// </summary>
        /// <param name="data">data to the forward</param>
        public void ForwardData(string data)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.EnqueueData(data);
            }
        }
    }

}
