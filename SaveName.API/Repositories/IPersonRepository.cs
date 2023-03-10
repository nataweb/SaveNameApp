using SaveName.API.Models.Domain;

namespace SaveName.API.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<PersonsData> GetAll();
    }
}
