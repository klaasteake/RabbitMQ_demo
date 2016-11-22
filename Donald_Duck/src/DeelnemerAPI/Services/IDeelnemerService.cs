using DeelnemerAPI.Models;

namespace DeelnemerAPI.Services
{
    public interface IDeelnemerService
    {
        void Execute(CreatePerson deelnemer);
        void Execute(UpdatePerson deelnemer);
        void Execute(DeletePerson deelnemer);
    }
}