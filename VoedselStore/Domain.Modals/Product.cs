namespace WebApplication1.Core.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool ContainsAlcohol { get; set; }

        public string Photo { get; set; } = null!;

        public ICollection<MealBox> MealBoxes { get; set; } = null!;

    }
}
