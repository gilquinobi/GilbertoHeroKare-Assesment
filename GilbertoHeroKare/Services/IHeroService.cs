using GilbertoHeroKare.Models;
using System.Collections.Generic;

namespace GilbertoHeroKare.Services
{
    public interface IHeroService
    {
        List<Hero> GetAllHeroes();
        
    }
}