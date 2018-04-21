using PubSubPattern.Abstract;
using PubSubPattern.Interface;
using System;

namespace PubSubPattern.Concrete
{
    public class FormattedSubscriber : Subscriber
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageBroker">Message broker subscribe to</param>
        public FormattedSubscriber(IMessageBroker messageBroker) : base(messageBroker)
        {
        }

        /// <summary>
        /// Return all the data in the queue with proper formatting
        /// </summary>
        /// <returns>all the data in the queue with proper formatting</returns>
        public override string GetDisplayData()
        {
            var output = "Retrieve Formatted Data" + Environment.NewLine;
            output = output + "-------------------" + Environment.NewLine;
            while (this.queue.Count > 0)
            {
                string data = this.queue.Dequeue();
                output = output + data + Environment.NewLine;
            }
            output = output + "-------------------";

            return output;
        }
    }
}
