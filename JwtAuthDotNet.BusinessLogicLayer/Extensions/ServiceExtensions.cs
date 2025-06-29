using JwtAuthDotNet.BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.BusinessLogicLayer.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserService, UserService>();

            return serviceCollection;
        }
    }
}
