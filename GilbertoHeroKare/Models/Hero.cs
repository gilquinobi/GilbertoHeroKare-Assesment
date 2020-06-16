using System.Collections.Generic;

namespace GilbertoHeroKare.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int RatingMedian { get; set; }
        public byte[] Picture { get; set; }
        public List<Rating> RatingHistorial { get; set; }


    }
}