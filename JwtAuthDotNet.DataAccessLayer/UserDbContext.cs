using JwtAuthDotNet.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.DataAccessLayer
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Username);
            modelBuilder.Entity<User>().Property(u => u.PasswordHash).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
