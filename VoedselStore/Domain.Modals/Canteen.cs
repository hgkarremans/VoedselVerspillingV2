using WebApplication1.Core.Domain.Model.Enums;

namespace WebApplication1.Core.Domain.Model
{
    public class Canteen
    {
        public int Id { get; set; }
        public City City { get; set; }
        public bool WarmMeals { get; set; }
    }
}
