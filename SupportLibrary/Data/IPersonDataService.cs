using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task<List<IPersonModel>> ReadPeople();
    }
}