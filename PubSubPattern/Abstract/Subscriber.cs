using PubSubPattern.Interface;
using System.Collections.Generic;

namespace PubSubPattern.Abstract
{
    public abstract class Subscriber
    {
        /// <summary>
        /// Queue to store all data
        /// </summary>
        protected Queue<string> queue = new Queue<string>();

        /// <summary>
        /// Register to the message broker
        /// </summary>
        /// <param name="messageBroker">message broker subscribe to</param>
        public Subscriber(IMessageBroker messageBroker)
        {
            messageBroker.Subscribe(this);
        }

        /// <summary>
        /// Subclass can return different display format
        /// </summary>
        /// <returns></returns>
        abstract public string GetDisplayData();

        /// <summary>
        /// Enqueue the data into the queue
        /// </summary>
        /// <param name="data">Data received from message broker</param>
        public void EnqueueData(string data)
        {
            this.queue.Enqueue(data);
        }
    }
}
