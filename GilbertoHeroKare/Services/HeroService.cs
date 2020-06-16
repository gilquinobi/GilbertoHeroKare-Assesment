using GilbertoHeroKare.Models;
using GilbertoHeroKare.Repository;
using System.Collections.Generic;

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

            return heroes;
        }
    }
}