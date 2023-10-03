using WebApplication1.Core.Domain.Model.Enums;

namespace WebApplication1.Core.Domain.Model
{
    public class MealBox
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public City City { get; set; }
        public Canteen Canteen { get; set; } = null!;
        public DateTime PickUpDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool EighteenPlus { get; set; }
        public decimal Price { get; set; }
        public MealType MealType { get; set; }
        public Student? ReservedStudent { get; set; }

        public ICollection<Product> products { get; set; } = null!;

    }
}