using Microsoft.EntityFrameworkCore;
using RCSolutions.Core.Entities;
using System.Linq;

namespace RCSolutions.Infra
{
    public class RCSolutionsContext : DbContext
    {
        public RCSolutionsContext(DbContextOptions<RCSolutionsContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RCSolutionsContext).Assembly);
        }
    }
}
