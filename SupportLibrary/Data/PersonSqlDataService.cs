using SupportLibrary.DataAccess;
using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public class PersonSqlDataService : IPersonDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        public PersonSqlDataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task CreatePerson(IPersonModel person)
        {
            var p = new { person.FirstName, person.LastName, person.DateOfBirth };

            await _dataAccess.SaveData("dbo.spPeople_Create", p, "SQLDB");
        }
    }
}
