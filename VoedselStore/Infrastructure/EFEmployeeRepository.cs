﻿using VoedselStore.Domain.Modals;
using VoedselStore.Domain.Services;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private readonly StoreDbContext context;

        public EFEmployeeRepository(StoreDbContext storeDbContext)
        {
            context = storeDbContext;
        }

        public IQueryable<Employee> GetAll => context.Employees;
    }
}
