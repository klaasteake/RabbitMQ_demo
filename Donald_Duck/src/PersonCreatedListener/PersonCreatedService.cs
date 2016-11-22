using rabbitmq_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeelnemerDatabase;

namespace PersonCreatedListener
{
    public class PersonCreatedService : IReceive<PersonCreated>, IReceive<PersonCreateFailed>
    {
        IDeelnemerContext _context;

        public PersonCreatedService(IDeelnemerContext context)
        {
            _context = context;
        }

        public void Execute(PersonCreateFailed item)
        {
            
        }

        public void Execute(PersonCreated item)
        {
            if (!_context.Deelnemers.Any(p => p.Id == item.Id))
            {
                //Receiving and saving
                _context.Deelnemers.Add(item);
                _context.SaveChanges();
            }
            


            //Optional Send a message back;
        }
    }
}
