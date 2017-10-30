using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> dboptions) : base(dboptions)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
