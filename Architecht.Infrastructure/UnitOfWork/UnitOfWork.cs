using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories.ECommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArchitechtContext _architechtContext;
        private readonly ICategoryRepository _categoryRepository;


        public UnitOfWork(ArchitechtContext architechtContext, ICategoryRepository categoryRepository)
        {
            _architechtContext = architechtContext;
            _categoryRepository = categoryRepository;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository;


        public void Dispose()
        {
            _architechtContext.Dispose();
        }

        public void SaveChanges()
        {
            _architechtContext.SaveChanges();
        }
    }
}
