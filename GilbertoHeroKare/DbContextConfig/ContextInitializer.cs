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
            },
                new Hero
            {
                Id = 6,
                Name = "Superman",
                Age = 35,
                City = "New York",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/274.jpg?"
            },
                new Hero
            {
                Id = 7,
                Name = "Black Widow",
                Age = 29,
                City = "Chicago",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/248.jpg?v=1578709372"
            },
                new Hero
            {
                Id = 8,
                Name = "Thor",
                Age = 30,
                City = "Asgard",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/140.jpg?v=1578981491"
            },
                new Hero
            {
                Id = 9,
                Name = "Hellboy",
                Age = 40,
                City = "Hell",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/813.jpg?v=1578651937"
            },
                new Hero
            {
                Id = 10,
                Name = "Dr Manhattan",
                Age = 39,
                City = "Chicago",
                Picture = "https://www.superherodb.com/pictures2/portraits/10/050/884.jpg?v=1578651406"
            }

            };

            var ratings = new List<Rating>
            {
                new Rating { Id = 1, Value = 2, HeroId = 1, Reviewer = "John" },
                new Rating { Id = 2, Value = 1, HeroId = 1, Reviewer = "Alex" },
                new Rating { Id = 3, Value = 5, HeroId = 2, Reviewer = "Peter" },
                new Rating { Id = 4, Value = 3, HeroId = 3, Reviewer = "Carlos" },
                new Rating { Id = 5, Value = 5, HeroId = 4, Reviewer = "Leon" },
                new Rating { Id = 6, Value = 4, HeroId = 6, Reviewer = "Laura" },
                new Rating { Id = 7, Value = 3, HeroId = 6, Reviewer = "Edward" },
                new Rating { Id = 8, Value = 2, HeroId = 7, Reviewer = "Arnold" },
                new Rating { Id = 9, Value = 1, HeroId = 8, Reviewer = "Dexter" },
                new Rating { Id = 10, Value = 1, HeroId = 9, Reviewer = "Robert" },
                new Rating { Id = 11, Value = 3, HeroId = 10, Reviewer = "Carla" },
                new Rating { Id = 12, Value = 5, HeroId = 10, Reviewer = "Stuart" },
                new Rating { Id = 13, Value = 4, HeroId = 7, Reviewer = "Jacob" },
                new Rating { Id = 14, Value = 2, HeroId = 6, Reviewer = "Michael" },
                new Rating { Id = 15, Value = 4, HeroId = 7, Reviewer = "Jason" },
                new Rating { Id = 16, Value = 1, HeroId = 9, Reviewer = "Chuck" },
                new Rating { Id = 17, Value = 2, HeroId = 10, Reviewer = "Paul" },
                new Rating { Id = 18, Value = 5, HeroId = 2, Reviewer = "Emma" },
                new Rating { Id = 19, Value = 3, HeroId = 4, Reviewer = "Olvia" },
                new Rating { Id = 20, Value = 1, HeroId = 5, Reviewer = "Mia" }
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