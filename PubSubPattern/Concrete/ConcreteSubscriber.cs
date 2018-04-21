using PubSubPattern.Abstract;
using PubSubPattern.Interface;
using System;

namespace PubSubPattern.Concrete
{
    public class ConcreteSubscriber : Subscriber
    {
        /// <summary>
        /// Extra name to identify object
        /// </summary>
        private string _subscriberName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="subscriberName">Name of the subscriber</param>
        /// <param name="messageBroker">Message broker subscribe to</param>
        public ConcreteSubscriber(string subscriberName, IMessageBroker messageBroker) : base(messageBroker)
        {
            _subscriberName = subscriberName;
        }

        /// <summary>
        /// Return all the data in the queue with subsciber name
        /// </summary>
        /// <returns>all the data in the queue with subsciber name</returns>
        public override string GetDisplayData()
        {
            var output = _subscriberName + "'s Data : " + Environment.NewLine;

            while (this.queue.Count > 0)
            {
                string data = this.queue.Dequeue();
                output = output + data + Environment.NewLine;
            }

            return output;
        }
    }
}
