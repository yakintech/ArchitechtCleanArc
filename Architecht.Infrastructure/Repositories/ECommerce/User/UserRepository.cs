﻿using Architecht.Domain.Models;
using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories;
using Architecht.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(ArchitechtContext context) : base(context)
        {

        }

    }
}