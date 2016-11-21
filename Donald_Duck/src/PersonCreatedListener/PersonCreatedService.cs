using rabbitmq_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeelnemerDatabase;

namespace PersonCreatedListener
{
    public class PersonCreatedService : IReceive<PersonCreated>
    {
        IDeelnemerContext _context;

        public PersonCreatedService(IDeelnemerContext context)
        {
            _context = context;
        }
        public void Execute(PersonCreated item)
        {
            //Receiving and saving
            _context.Deelnemers.Add(item);
            _context.SaveChanges();


            //Optional Send a message back;
        }
    }
}
