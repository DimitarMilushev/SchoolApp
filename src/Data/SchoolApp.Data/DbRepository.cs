using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Data.Common;

namespace SchoolApp.Data
{
    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
    where TEntity : class
    {
        private readonly SchoolAppContext context;
        private DbSet<TEntity> dbSet;

        public DbRepository(SchoolAppContext context, DbSet<TEntity> dbSet)
        {
            this.context = context;
            this.dbSet = this.context.Set<TEntity>();
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public Task AddAsync(TEntity entity)
        {
            return this.dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
