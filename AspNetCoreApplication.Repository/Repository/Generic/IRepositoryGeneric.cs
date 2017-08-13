using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Repository.Repository.Generic
{
    public interface IRepositoryGeneric<TEntity> where TEntity : class
    {
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity FindById(params object[] keyValues);
        IEnumerable<TEntity> GetAll();

        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> FindByIdAsync(params object[] keyValues);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
