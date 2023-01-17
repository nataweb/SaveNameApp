using SaveName.API.Models.Domain;
using SaveName.API.Repositories;

namespace SaveName.API.Models.Domain
{
    public class PersonsData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BankAccount { get; set; }
    }
}
    