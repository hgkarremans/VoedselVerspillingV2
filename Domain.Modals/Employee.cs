namespace WebApplication1.Core.Domain.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int EmployeeNumber { get; set; }
        public Canteen Canteen { get; set; } = null!;
        public int CanteenId { get; set; }
    }
}
