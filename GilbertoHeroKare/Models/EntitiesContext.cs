using GilbertoHeroKare.DbContextConfig;
using System.Data.Entity;

namespace GilbertoHeroKare.Models
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("EntitiesContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EntitiesContext, 
                ContextInitializer>());

        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}