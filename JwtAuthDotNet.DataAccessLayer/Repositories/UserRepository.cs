using JwtAuthDotNet.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.DataAccessLayer.Repositories
{
    public class UserRepository(UserDbContext context) : IUserRepository
    {
        public async Task AddAsync(User user)
        {
            if (await context.Users.AnyAsync(u => u.Username == user.Username))
            {
                throw new Exception("User already exists");
            }

            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            return await
                context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User?> GetUserById(Guid userId)
        {
            return await
                context.Users
                .AsNoTracking()
                .FirstAsync(u => u.Id == userId);
        }

        public async Task UpdateAsync(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
