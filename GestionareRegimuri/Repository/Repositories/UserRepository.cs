using GestionareRegimuri.Data;
using GestionareRegimuri.Models;
using GestionareRegimuri.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GestionareRegimuri.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(ApplicationDbContext DbContext, UserManager<User> userManager) : base(DbContext)
        {
            _userManager = userManager;
        }

        public override IQueryable<User> FindByCondition(Expression<Func<User, bool>> expression)
        {
            return DbContext.Set<User>().Where(expression);
        }

        public async Task<User> getCurrentUserAsync(ClaimsPrincipal user)
        {
            return await _userManager.GetUserAsync(user);
        }
    }
}
