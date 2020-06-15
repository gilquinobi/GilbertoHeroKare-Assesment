using GilbertoHeroKare.Models;
using System.Collections.Generic;

namespace GilbertoHeroKare.Repository
{
    public interface IHeroRepository
    {
        List<Hero> GetAllHeroes();

    }
}