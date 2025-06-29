using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.DataAccessLayer.Extensions
{
    public static class DataAcessExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("UserDatabase"), 
                    b => b.MigrationsAssembly("JwtAuthDotNet.DataAccessLayer"));
            });

            return services;
        }
    }
}
