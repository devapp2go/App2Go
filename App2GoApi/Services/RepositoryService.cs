using App2GoApi.Data;
using App2GoApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Services
{
    public class RepositoryService<TEntity> : IRepositoryService<TEntity> where TEntity : BaseEntity
    {
        DbSet<TEntity> entities;
        App2GoDBContext _context;
        public RepositoryService(App2GoDBContext context)
        {
            _context = context;
            entities = _context.Set<TEntity>();
        }

        public async Task<bool> Add(TEntity entity)
        {
            entity.Created = DateTime.Now;
            entity.Updated = DateTime.Now;
            entities.Add(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Remove register permanently of BD
        /// </summary>
        /// <returns>True if was changes in BD</returns>
        public bool Delete(TEntity entity)
        {
            entities.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// Set soft delete in BD
        /// </summary>
        /// <returns>True if was changes in BD</returns>
        public bool SoftDelete(TEntity entity)
        {
            entity.Deleted = DateTime.Now;
            entity.Active = false;
            entities.Update(entity);
            return _context.SaveChanges() > 0;
        }

        public async Task<bool> Update(TEntity entity)
        {
            entity.Updated = DateTime.Now;
            entities.Update(entity);
            return await _context.SaveChangesAsync() > 0;

        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.Where(ent => ent.Active).ToList();
        }

        public TEntity GetById(int Id)
        {
            return entities.AsNoTracking().FirstOrDefault(entity => entity.Id == Id && entity.Active);
        }
    }
}
