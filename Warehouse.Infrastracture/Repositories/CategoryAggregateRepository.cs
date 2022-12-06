﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    internal class CategoryAggregateRepository : BaseAggregateRepository<Category>
    {
        public CategoryAggregateRepository(WarehouseDbContext context): base(context)
        {
        }
    }
}
