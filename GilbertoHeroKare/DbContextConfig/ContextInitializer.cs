using GilbertoHeroKare.Models;

namespace GilbertoHeroKare.DbContextConfig
{
    public class ContextInitializer : System.Data.Entity.Migrations.DbMigrationsConfiguration<EntitiesContext>
    {
        public ContextInitializer()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(EntitiesContext context)
        {
            context.Heroes.Add(new Hero
            {
                Id = 1,
                Name = "Spider Man",
                Age = 25,
                City = 
                "New York"
            });

            base.Seed(context);
            context.SaveChanges();

        }
    }
}