using System.Collections.Generic;

namespace GilbertoHeroKare.Models
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string Rating { get; set; }
        public string Picture { get; set; }
        public List<Rating> RatingHistorial { get; set; }


    }
}