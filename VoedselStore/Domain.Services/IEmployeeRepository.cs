using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Domain.Services
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetAll { get; }
    }
}
