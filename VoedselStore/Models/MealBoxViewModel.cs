using System.ComponentModel.DataAnnotations;
using WebApplication1.Core.Domain.Model;
using WebApplication1.Core.Domain.Model.Enums;

namespace VoedselStore.Models
{
    public class MealBoxViewModel
    {
        [Required]
        public string Name { get; set; } = null!;
        public IEnumerable<Product> Products { get; set; } = null!;
        public City city { get; set; }
        public Canteen canteen { get; set; } = null!;
        public DateTime PickUpDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool EighteenPlus { get; set; }
        public decimal Price { get; set; }
        public MealType MealType { get; set; }
        public Student? ReservedStudent { get; set; }
        

    }
}
