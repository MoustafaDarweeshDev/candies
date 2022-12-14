using core.Entites;
using core.Interfaces;
using core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext context;

        public GenericRepository(StoreContext context)
        {
            this.context = context;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllAsyncWithSpec(ISpecification<T> spec = null)
        {
            return await ApplySpecifications(spec).ToListAsync();
        }


        private IQueryable<T> ApplySpecifications(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQury(context.Set<T>().AsQueryable(), spec);   
        }

    }
}
