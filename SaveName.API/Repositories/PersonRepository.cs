using SaveName.API.Data;
using SaveName.API.Models.Domain;
using SaveName.API.Repository;

namespace SaveName.API.Repositories
{   
    public class PersonRepository : IPersonRepository
    {
        private readonly SaveNameDbContext _saveNameDbContext;

        public PersonRepository(SaveNameDbContext saveNameDbContext)
        {
            _saveNameDbContext = saveNameDbContext;
        }
        public IEnumerable<PersonData> GetAll()
        {
           return _saveNameDbContext.PersonsData.ToList();
        }
    }
}
