using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeelnemerDatabase;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using rabbitmq_demo;
using Autofac;
using RabbitMQ.Client;

namespace PersonCreatedListener
{
    public class Program
    {


        public static void Main(string[] args)
        {
            //Arrange
            var options = new DbContextOptionsBuilder<DeelnemerContext>()
                .UseSqlServer(@"Server=.\SQLEXPRESS;Database=JeroenDonaldDuckDeelnemers;Trusted_Connection=true")
                .Options;


            var builder = new ContainerBuilder();
            builder
                .RegisterType<DeelnemerContext>()
                .As<IDeelnemerContext>();

            builder
                .RegisterInstance(options);

            builder.RegisterReceiverFor<PersonCreatedService, PersonCreated>();
            builder.RegisterReceiverFor<PersonCreatedService, PersonCreateFailed>();

            using (var container = builder.Build())
            using (var listener = new Listener(new ConnectionFactory { HostName = "curistm01", UserName = "manuel", Password= "manuel" }, "DeelnemerAdministratie"))
            {


                Console.WriteLine("PersonCreated Listener is now listening!");
                Console.WriteLine("Type 'Close' followed by 'Enter' key to exit the program!");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();

                listener.SubscribeEvents<PersonCreated>(container);
                listener.SubscribeEvents<PersonCreateFailed>(container);
                listener.Received += Show_Incoming_PersonCreated;


                var key = Console.ReadLine();
                if (key == "Close")
                {
                    Console.WriteLine("PersonCreated Listener will now close!");
                    Thread.Sleep(1000);
                }

            }
        }

        private static void Show_Incoming_PersonCreated(object sender, ReceivedEventArgs e)
        {
            Console.WriteLine(e);
        }
    }
}
