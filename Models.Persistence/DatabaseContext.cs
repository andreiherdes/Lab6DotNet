using System;
using Microsoft.EntityFrameworkCore;
using Models.Domain.Entities;

namespace Models.Persistence
{
    public sealed class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("");
        }

        int IDatabaseContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<MenuCard> MenuCards { get; set; }
        
    }
}
