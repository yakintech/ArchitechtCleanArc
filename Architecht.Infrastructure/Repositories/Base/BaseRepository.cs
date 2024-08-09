using Architecht.Domain.Models;
using Architecht.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        internal ArchitechtContext _context;
        internal DbSet<T> _dbSet;

        public BaseRepository(ArchitechtContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Create(T entity)
        {
            entity.Id = Guid.NewGuid();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entity.IsDeleted = false;

            _dbSet.Add(entity);

            return entity;
        }

        public void Delete(Guid id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
            }
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            var entity = _dbSet.FirstOrDefault(x => predicate(x) && x.IsDeleted == false);
            
            if (entity == null)
                throw new Exception("Entity not found");
            return entity;
            
        }

        public IQueryable<T> GetAll()
        {
            var entities = _dbSet.Where(x => x.IsDeleted == false);
            return entities;
        }

        public IQueryable<T> GetAll(int page, int pageSize)
        {
            var entities = _dbSet.Where(x => x.IsDeleted == false).Skip((page - 1) * pageSize).Take(pageSize);
            return entities;
        }

        public IQueryable<T> GetAll(Func<T, bool> predicate)
        {
            var entities = _dbSet.Where(x => predicate(x) && x.IsDeleted == false);
            return entities;
        }

        public IQueryable<T> GetAll(Func<T, bool> predicate, int page, int pageSize)
        {
           var entities = _dbSet.Where(x => predicate(x) && x.IsDeleted == false).Skip((page - 1) * pageSize).Take(pageSize);
            return entities;
        }

        public IQueryable<T> GetAll(params string[] include)
        {
            var entities = _dbSet.Where(x => x.IsDeleted == false);
            foreach (var item in include)
            {
                entities = entities.Include(item);
            }
            return entities;
           
            
        }

        public T GetById(Guid id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            return entity;
        }

        public T Update(T entity)
        {
            var entityToUpdate = _dbSet.FirstOrDefault(x => x.Id == entity.Id && x.IsDeleted == false);
            if (entityToUpdate != null)
            {
                entity.UpdatedAt = DateTime.Now;
                _context.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            }
            return entity;
        }
    }
}
