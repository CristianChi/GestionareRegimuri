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
    public class IndicatiiRepository : RepositoryBase<Indicatii>, IIndicatiiRepository
    {

        public IndicatiiRepository(ApplicationDbContext DbContext) : base(DbContext)
        {
        }
    }
}
