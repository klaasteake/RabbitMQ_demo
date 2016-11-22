using RabbitMQ.Client;
using rabbitmq_demo;

namespace DeelnemerAPI.Services
{
    static public class DeelnemerServiceProvider
    {
        public static DeelnemerService Provide()
        {
            var factory = new ConnectionFactory { HostName = "curistm01", UserName = "manuel", Password = "manuel" };
            var sender = new Sender(factory, "DeelnemerAdminstratie");
            return new DeelnemerService(sender);
        }
    }
}
