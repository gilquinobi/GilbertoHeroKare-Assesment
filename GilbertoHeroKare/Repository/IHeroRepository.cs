using GilbertoHeroKare.Models;
using System.Collections.Generic;

namespace GilbertoHeroKare.Repository
{
    public interface IHeroRepository
    {
        IEnumerable<Hero> GetAllHeroes();
        IEnumerable<Rating> GetHeroRatings();

    }
}