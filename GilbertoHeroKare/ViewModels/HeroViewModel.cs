using GilbertoHeroKare.Models;
using System.Collections.Generic;

namespace GilbertoHeroKare.ViewModels
{
    public class HeroViewModel
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
            public int RatingMedian { get; set; }
            public byte[] Picture { get; set; }
            public List<Rating> RatingHistorial { get; set; }        
    }
}