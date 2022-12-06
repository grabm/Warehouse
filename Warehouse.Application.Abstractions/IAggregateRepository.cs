using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Abstraction;

namespace Warehouse.Application.Abstractions
{
    public interface IAggregateRepository<TAggregate> where TAggregate: IAggregateRoot
    {
        Task CreateAsync(TAggregate entity);
        Task<TAggregate> GetAsync(long id);
        Task SaveChangesAsync();

    }
}
