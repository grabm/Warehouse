using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.ReadModels
{
    public class WarehouseReadModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long RegionId { get;  set; }

        public AddressReadModel Address { get; set; }

    }
}
