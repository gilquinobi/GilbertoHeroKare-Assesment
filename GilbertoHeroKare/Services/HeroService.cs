using GilbertoHeroKare.Models;
using GilbertoHeroKare.Repository;
using System.Collections.Generic;
using System.Linq;

namespace GilbertoHeroKare.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;

        public HeroService(IHeroRepository heroRepository)
        {
             _heroRepository= heroRepository;
        }

        public IEnumerable<Hero> GetAllHeroes()
        {
            var heroes = _heroRepository.GetAllHeroes();
            var ratings = _heroRepository.GetHeroRatings();

            foreach(var hero in heroes)
            {
                hero.RatingHistorial = ratings.Where(r => r.HeroId == hero.Id);
            }    

            return heroes;
        }
    }
}