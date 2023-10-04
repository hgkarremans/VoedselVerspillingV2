using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Domain.Services
{
    public interface IStudentRepository
    {
        IQueryable<Student> GetAll { get; }
    }
}
