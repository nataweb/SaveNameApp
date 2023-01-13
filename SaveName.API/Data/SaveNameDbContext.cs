using Microsoft.EntityFrameworkCore;
using SaveName.API.Models.Domain;

namespace SaveName.API.Data
{
    public class SaveNameDbContext: DbContext
    {
        public SaveNameDbContext(DbContextOptions<SaveNameDbContext> options)
         : base(options)
        {

        }
        public DbSet<PersonData> PersonsData { get; set; }
    }
}
