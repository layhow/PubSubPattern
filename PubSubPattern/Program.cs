using PubSubPattern.Concrete;
using PubSubPattern.Interface;
using System;

namespace PubSubPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get User input
            User user = GetInput();

            //Data Transform, this could enhance with dependency injection or strategy pattern to change the
            // transformation method during run time.
            string userData = Newtonsoft.Json.JsonConvert.SerializeObject(user);

            //Register the publisher to the message broker
            MessageBroker messageBroker = new MessageBroker();
            Publisher publisher = new Publisher(messageBroker);

            //Subscibe to the message broker
            ConcreteSubscriber subscriber1 = new ConcreteSubscriber("Subscriber 1", messageBroker);
            FormattedSubscriber formattedSubscriber = new FormattedSubscriber(messageBroker);

            // Publish to all subscriber
            publisher.PublishData(userData);

            //Display Data
            Console.WriteLine(subscriber1.GetDisplayData());
            Console.WriteLine(formattedSubscriber.GetDisplayData());

            Console.ReadLine();
        }

        /// <summary>
        /// Display the message to the user for input. Return the input in User object
        /// </summary>
        /// <returns>User Object</returns>
        private static User GetInput()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Nationality:");
            string nationality = Console.ReadLine();

            User user = new User(name, nationality);

            return user;
        }
    }
}
