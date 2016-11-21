using rabbitmq_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonCreatedListener
{
    public class PersonCreatedService : IReceive<PersonCreated>
    {
        IPersonCreatedContext _context;

        public PersonCreatedService(IPersonCreatedContext context)
        {
            _context = context;
        }
        public void Execute(PersonCreated item)
        {
            //Receiving and saving
            _context.Persons.Add(item);
            _context.SaveChanges();


            //Optional Send a message back;
        }
    }
}
