using Microsoft.EntityFrameworkCore;
using Models.Domain.Entities;

namespace Models.Persistence
{
    public interface IDatabaseContext
    {
        DbSet<MenuCard> MenuCards { get; set; }
        int SaveChanges();
    }
}
