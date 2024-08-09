﻿using Architecht.Domain.Models;
using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(ArchitechtContext context) : base(context)
        {
        }
    }
}