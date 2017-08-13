using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreApplication.Data;

namespace AspNetCoreApplication.Repository
{
    public class RepositoryGeneric<TEntity> : IRepositoryGeneric<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext context;

        public RepositoryGeneric(ApplicationDbContext context)
        {
            this.context = context;
        }

        public TEntity FindById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindByIdAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
