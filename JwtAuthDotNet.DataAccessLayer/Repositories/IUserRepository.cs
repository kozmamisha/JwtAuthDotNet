using JwtAuthDotNet.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<User?> GetUserByUsername(string username);
    }
}
