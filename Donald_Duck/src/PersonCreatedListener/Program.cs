using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeelnemerDatabase;
using Microsoft.EntityFrameworkCore;
using System.Threading;

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


            bool running = true;


            using (var context = new DeelnemerContext(options))
            {
                var service = new PersonCreatedService(context);

                Console.WriteLine("PersonCreated Listener is now listening!");
                Console.WriteLine("Type 'Close' followed by 'Enter' key to exit the program!");
                Console.WriteLine("----------------------------------------");

                while (running)
                {
                    Thread.Sleep(4000);

                    var key = Console.ReadLine();
                    if (key == "Close")
                    {
                        Console.WriteLine("PersonCreated Listener will now close!");
                        Thread.Sleep(1000);
                        running = false;
                    }

                }

            }

                


        }
    }
}
