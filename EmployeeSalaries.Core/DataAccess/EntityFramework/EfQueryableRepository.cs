using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.Core.Entities;

namespace EmployeeSalaries.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class,IEntity,new()
    {
        private readonly DbContext _context; // dinject
        private IDbSet<T> _dbSet;
        public EfQueryableRepository(DbContext context, IDbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }
        public IQueryable<T> Table => Entities;
        protected virtual IDbSet<T> Entities => _dbSet ?? (_dbSet = _context.Set<T>());
    }
}
