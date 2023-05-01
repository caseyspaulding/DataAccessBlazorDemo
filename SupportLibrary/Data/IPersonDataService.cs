using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task<List<IPersonModel>> ReadPeople();
        Task<IPersonModel> ReadPeople(int id);
        Task UpdatePerson(IPersonModel person);
    }
}