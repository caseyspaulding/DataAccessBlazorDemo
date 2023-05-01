using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task DeletePerson(int id);
        Task<List<IPersonModel>> ReadPeople();
        Task<IPersonModel> ReadPeople(int id);
        Task<List<IPersonModel>> SearchPeople(string searchTerm);
        Task UpdatePerson(IPersonModel person);
    }
}