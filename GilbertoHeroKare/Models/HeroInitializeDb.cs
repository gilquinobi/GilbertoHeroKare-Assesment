using System.Data.Entity;
using System.Drawing;
using System.Security.AccessControl;

namespace GilbertoHeroKare.Models
{
    public class HeroInitializeDb : DropCreateDatabaseIfModelChanges<EntitiesContext>
    {
        protected override void Seed(EntitiesContext context)
        {
            context.Heroes.Add(new Hero
            {
                Id = 1,
                Name = "Spider Man",
                Age = 25,
                City = "New York",
                RatingMedian = 0
            });

            context.SaveChanges();

            base.Seed(context);
        }

        public static byte[] GetImage(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
    }
}