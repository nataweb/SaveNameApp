using SaveName.API.Data;
using SaveName.API.Models.Domain;
using SaveName.API.Repository;
using System.Security.Cryptography;


namespace SaveName.API.Repositories
{   
    public class PersonRepository : IPersonRepository
    {
        
        private readonly SaveNameDbContext _saveNameDbContext;
        
        public PersonRepository(SaveNameDbContext saveNameDbContext)
        {
            _saveNameDbContext = saveNameDbContext;
            
        }

        public IEnumerable<PersonsData> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
