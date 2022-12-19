using Euvic.Cqrs.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Application.Features.Region.Commands.CreateRegion
{
    public class CreateRegionCommand: ICommand<long>
    {
        public string Name { get; set; }
    }
}
