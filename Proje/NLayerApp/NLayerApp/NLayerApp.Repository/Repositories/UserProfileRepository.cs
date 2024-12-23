﻿using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Repositories
{
    public class UserProfileRepository:GenericRepository<UserProfile>,IUserProfileRepository
    {
        public UserProfileRepository(AppDbContext dbContext) :base(dbContext)
        {

        }
    }
}
