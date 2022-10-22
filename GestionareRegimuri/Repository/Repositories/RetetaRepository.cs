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
    public class RetetaRepository : RepositoryBase<Reteta>, IRetetaRepository
    {
        public RetetaRepository(ApplicationDbContext DbContext) : base(DbContext)
        {
        }

        public override IQueryable<Reteta> FindByCondition(Expression<Func<Reteta, bool>> expression)
        {
            return DbContext.Set<Reteta>().Where(expression);
        }
    }
}
