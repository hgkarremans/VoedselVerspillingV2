using WebApplication1.Core.Domain.Model.Enums;

namespace WebApplication1.Core.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int StudentNumber { get; set; }
        public City City { get; set; }
        public string PhoneNumber { get; set; } = null!;


    }
}
