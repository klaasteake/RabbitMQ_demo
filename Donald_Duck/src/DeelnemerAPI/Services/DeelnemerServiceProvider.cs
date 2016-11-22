using RabbitMQ.Client;
using rabbitmq_demo;

namespace DeelnemerAPI.Services
{
    static public class DeelnemerServiceProvider
    {
        public static DeelnemerService Provide()
        {
            var factory = new ConnectionFactory { };
            var sender = new Sender(factory, "DeelnemerRegistratie");
            return new DeelnemerService(sender);
        }
    }
}
