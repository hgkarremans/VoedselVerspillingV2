using VoedselStore.Domain.Modals;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure
{
    public class EFStudentRepository
    {
        private readonly StoreDbContext context;

        public EFStudentRepository(StoreDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Student> GetAll() => context.Students;
    }
}
