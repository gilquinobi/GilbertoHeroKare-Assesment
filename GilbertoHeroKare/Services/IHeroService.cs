using GilbertoHeroKare.Models;
using System.Collections.Generic;

namespace GilbertoHeroKare.Services
{
    public interface IHeroService
    {
        IEnumerable<Hero> GetAllHeroes();
        
    }
}