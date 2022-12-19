using Euvic.Cqrs.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Features.Shared.Models;

namespace Warehouse.Application.Features.Warehouse.Commands.CreateWarehouse
{
    public class CreateWarehouseCommand : ICommand<long>
    {
        public string Name { get; set; }
        public long RegionId { get; set; }
        public Address Address { get; set; }
    }
}