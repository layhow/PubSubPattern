using PubSubPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubPattern.Concrete
{
    public class Publisher
    {
        /// <summary>
        /// Message broker to publish the data
        /// </summary>
        private IMessageBroker _messageBroker;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageBroker"> Message broker used to publish the data</param>
        public Publisher(IMessageBroker messageBroker)
        {
            this._messageBroker = messageBroker;
        }

        /// <summary>
        /// Publish the data via message broker to all the subscriber
        /// </summary>
        /// <param name="data">data to be publish to subscriber</param>
        public void PublishData(string data)
        {
            _messageBroker.ForwardData(data);
        }
    }
}
