using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PubSubPattern.Concrete;
using PubSubPattern.Interface;

namespace UnitTest
{
    [TestClass]
    public class PubSubUnitTest
    {
        [TestMethod]
        public void TestPublisher()
        {
            string data = "test";
            var messageBrokerMock = new Mock<IMessageBroker>();

            var publisher = new Publisher(messageBrokerMock.Object);

            publisher.PublishData(data);

            messageBrokerMock.Verify(msgBroker => msgBroker.ForwardData(data), Times.AtLeastOnce);
        }

        [TestMethod]
        public void TestConcreteSubscriber()
        {
            string name = "concrete subscriber";
            string data = "test data";
            var messageBrokerMock = new Mock<MessageBroker>();

            var subscriber = new ConcreteSubscriber(name, messageBrokerMock.Object);

            subscriber.EnqueueData(data);

            Assert.AreEqual(name + "'s Data : \r\n" + data + "\r\n", subscriber.GetDisplayData());
        }
    }
}
