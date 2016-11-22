using DeelnemerAPI.Models;
using DeelnemerDatabase;
using rabbitmq_demo;

namespace DeelnemerAPI.Services
{
    public class DeelnemerService : IReceive<CreatePerson>, IReceive<UpdatePerson>, IReceive<DeletePerson>, IDeelnemerService
    {
        private ISender _sender;

        public DeelnemerService(ISender sender)
        {
            _sender = sender;
        }

        public void Execute(CreatePerson deelnemer)
        {
            _sender.PublishCommand(deelnemer);
        }

        public void Execute(UpdatePerson deelnemer)
        {
            _sender.PublishCommand(deelnemer);
        }

        public void Execute(DeletePerson deelnemer)
        {
            _sender.PublishCommand(deelnemer);
        }
    }
}
