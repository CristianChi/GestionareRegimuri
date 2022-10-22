using GestionareRegimuri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GestionareRegimuri.Repository.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        public Task<User> getCurrentUserAsync(ClaimsPrincipal user);
    }
}
