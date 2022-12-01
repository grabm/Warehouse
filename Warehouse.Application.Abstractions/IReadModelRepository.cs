using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Application.Abstractions
{
    public interface IReadModelRepository<TEntity>
    {
        IQueryable<TEntity> GetQuery();
        IEnumerable<TDto> ToListAsync<TDto>(IQueryable<TEntity> query);
    }
}
