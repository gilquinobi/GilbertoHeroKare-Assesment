using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GilbertoHeroKare.Models
{
    public class Hero
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        public int? RatingMedian { get; set; }
        public byte[] Picture { get; set; }
        public virtual IEnumerable<Rating> RatingHistorial { get; set; }


    }
}