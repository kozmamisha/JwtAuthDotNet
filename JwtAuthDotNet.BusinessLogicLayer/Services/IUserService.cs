using JwtAuthDotNet.BusinessLogicLayer.Models;
using JwtAuthDotNet.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthDotNet.BusinessLogicLayer.Services
{
    public interface IUserService
    {
        Task RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
    }
}
