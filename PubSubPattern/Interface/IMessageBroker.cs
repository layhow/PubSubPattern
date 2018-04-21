using PubSubPattern.Abstract;

namespace PubSubPattern.Interface
{

    /// <summary>
    /// Sub classes who implement this interface could customize the forward data, for eg, filtering.
    /// Can be enhance with topic subscription, only receive message/data based on the topic subscribed.
    /// </summary>
    public interface IMessageBroker
    {
        void ForwardData(string data);
        void Subscribe(Subscriber subscriber);
        void Unsubscribe(Subscriber subscriber);
    }

}
