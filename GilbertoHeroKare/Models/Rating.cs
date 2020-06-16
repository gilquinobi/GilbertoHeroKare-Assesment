using System.ComponentModel.DataAnnotations;

namespace GilbertoHeroKare.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Reviewer { get; set; }
        [Range(0, 5)]
        public int Value { get; set; }
        public int HeroId { get; set; }
    }
}