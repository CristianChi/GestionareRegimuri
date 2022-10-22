using GestionareRegimuri.Data;
using GestionareRegimuri.Models;
using GestionareRegimuri.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestionareRegimuri.Repository.Repositories
{
    public class BoalaRepository : RepositoryBase<Boala>, IBoalaRepository
    {
        public BoalaRepository(ApplicationDbContext DbContext) : base(DbContext)
        {
            
        }

        public override IQueryable<Boala> FindByCondition(Expression<Func<Boala, bool>> expression)
        {
            return DbContext.Set<Boala>().Where(expression);
        }
    }
}
