using GilbertoHeroKare.Models;
using System.Collections.Generic;
using System.Linq;

namespace GilbertoHeroKare.Repository
{
    public class HeroRepository : IHeroRepository
    {
        private readonly EntitiesContext _context = new EntitiesContext();

        public HeroRepository(EntitiesContext context)
        {
            _context = context;
        }

        public List<Hero> GetAllHeroes()
        {
            var heroes = _context.Heroes.ToList();

            return heroes;

        }
    }
}