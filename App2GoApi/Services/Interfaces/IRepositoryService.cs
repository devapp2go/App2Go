using App2GoApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Services.Interfaces
{
    public interface IRepositoryService<T> where T : BaseEntity
    {
        Task<bool> Add(T entity);
        bool Delete(T entity);
        bool SoftDelete(T entity);
        Task<bool> Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
