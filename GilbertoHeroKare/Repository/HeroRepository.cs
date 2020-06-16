using GilbertoHeroKare.Models;
using System.Collections.Generic;
using System.Linq;

namespace GilbertoHeroKare.Repository
{
    public class HeroRepository : IHeroRepository
    {
        private readonly EntitiesContext _context;

        public HeroRepository()
        {
            _context = new EntitiesContext();

        }

        public IEnumerable<Hero> GetAllHeroes()
        {
            var heroes = _context.Heroes.OrderByDescending(h => h.RatingMedian).ToList();

            return heroes;

        }

        public IEnumerable<Rating> GetHeroRatings()
        {
            var ratings = _context.Ratings.ToList();

            return ratings;
        }

    }
}