using System.Data.Entity;

namespace GilbertoHeroKare.Models
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("EntitiesContext")
        {
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Rating> Ratings { get; set; }

    }
}