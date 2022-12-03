using core.Entites;
using core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity>  where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQury(IQueryable<TEntity> table , ISpecification<TEntity> spec)
        {
            var query = table;

            if(spec.Certira != null)
            {
                query.Where(spec.Certira);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}
