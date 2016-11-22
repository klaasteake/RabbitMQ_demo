using DeelnemerAPI.Models;
using DeelnemerDatabase;
using rabbitmq_demo;

namespace DeelnemerAPI.Services
{
    public class DeelnemerService : IDeelnemerService
    {
        private ISender _sender;

        public DeelnemerService(ISender sender)
        {
            _sender = sender;
        }

        public void CreateDeelnemer(CreatePerson deelnemer)
        {
            _sender.PublishCommand(deelnemer);
        }

        public void UpdateDeelnemer(UpdatePerson deelnemer)
        {
            _sender.PublishCommand(deelnemer);
        }

        public void DeleteDeelnemer(DeletePerson deelnemer)
        {
            _sender.PublishCommand(deelnemer);
        }
    }
}
