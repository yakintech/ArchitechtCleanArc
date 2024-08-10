using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    public class LoggingRepository<T> : IRepository<T>
    {
        private readonly IRepository<T> _repository;

        public LoggingRepository(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            Console.WriteLine("Adding entity to the repository");
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            Console.WriteLine("Deleting entity from the repository");
            _repository.Delete(entity);
        }

        public T Get(int id)
        {
            Console.WriteLine("Getting entity from the repository");
            return _repository.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("Getting all entities from the repository");
            return _repository.GetAll();
        }

    }

}
