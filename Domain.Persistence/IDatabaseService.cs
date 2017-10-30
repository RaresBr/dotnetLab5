using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public interface IDatabaseService
    {
        DbSet<Product> Products { get; set; }
        int SaveChanges();
    }
}