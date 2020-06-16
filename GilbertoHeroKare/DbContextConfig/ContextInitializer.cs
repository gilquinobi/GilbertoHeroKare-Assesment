using GilbertoHeroKare.Helpers;
using GilbertoHeroKare.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace GilbertoHeroKare.DbContextConfig
{
    public class ContextInitializer : DbMigrationsConfiguration<EntitiesContext>
    {
        public ContextInitializer()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(EntitiesContext context)
        {
            var heroes = new List<Hero>
            {
                new Hero
            {
                Id = 1,
                Name = "Spider Man",
                Age = 25,
                City = "New York",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/133.jpg?v=1476386123"
            },
                new Hero
            {
                Id = 2,
                Name = "Batman",
                Age = 38,
                City = "Gotham",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/639.jpg?"
            },
                new Hero
            {
                Id = 3,
                Name = "Hulk",
                Age = 32,
                City = "Kansas",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/83.jpg?"
            },
                new Hero
            {
                Id = 4,
                Name = "Deadpool",
                Age = 30,
                City = "San Fransico",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/835.jpg?"
            },
                new Hero
            {
                Id = 5,
                Name = "Captain America",
                Age = 35,
                City = "Chicago",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/274.jpg?"
            }

            };

            var ratings = new List<Rating>
            {
                new Rating { Id = 1, Value = 2, HeroId = 1, Reviewer = "John" },
                new Rating { Id = 2, Value = 1, HeroId = 1, Reviewer = "Alex" },
                new Rating { Id = 3, Value = 5, HeroId = 2, Reviewer = "Peter" },
                new Rating { Id = 4, Value = 3, HeroId = 3, Reviewer = "Carlos" },
                new Rating { Id = 5, Value = 5, HeroId = 4, Reviewer = "Leon" },
                new Rating { Id = 6, Value = 2, HeroId = 4, Reviewer = "Jack" },
                new Rating { Id = 7, Value = 1, HeroId = 5, Reviewer = "Mike" }
            };

            if (!context.Ratings.Any())
            {
                foreach (var rating in ratings)
                {
                    context.Ratings.AddOrUpdate(rating);
                }
            }


            foreach (var hero in heroes)
            {
                //Get ratings values
                var ratingsValues = ratings.Where(r => r.HeroId == hero.Id).Select(r => r.Value).ToArray();

                //Calculate and set median
                hero.RatingMedian = MathHelper.GetMedian(ratingsValues);

            }

            if (!context.Heroes.Any())
            {
                foreach (var hero in heroes)
                {
                    context.Heroes.Add(hero);
                }
            }

            base.Seed(context);
            context.SaveChanges();

        }
    }
}