using Architecht.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T FirstOrDefault(Func<T, bool> predicate);
        T GetById(Guid id);

        IQueryable<T> GetAll();
        IQueryable<T> GetAll(int page, int pageSize);
        IQueryable<T> GetAll(Func<T, bool> predicate);
        IQueryable<T> GetAll(Func<T, bool> predicate, int page, int pageSize);

        //getAll with include
        IQueryable<T> GetAll(params string[] include);

        T Create(T entity);
        T Update(T entity);
        void Delete(Guid id);

    }
}
