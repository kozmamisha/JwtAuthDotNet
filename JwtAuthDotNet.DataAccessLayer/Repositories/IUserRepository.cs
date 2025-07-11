﻿using JwtAuthDotNet.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User?> GetUserByUsername(string username);
        Task<User?> GetUserById(Guid userId);
        Task UpdateAsync(User user);
    }
}
