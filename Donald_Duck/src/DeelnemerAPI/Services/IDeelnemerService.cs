using DeelnemerAPI.Models;

namespace DeelnemerAPI.Services
{
    public interface IDeelnemerService
    {
        void CreateDeelnemer(CreatePerson deelnemer);
        void UpdateDeelnemer(UpdatePerson deelnemer);
        void DeleteDeelnemer(DeletePerson deelnemer);
    }
}