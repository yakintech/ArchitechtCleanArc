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
        private readonly IProductRepository _productRepository;


        public UnitOfWork(ArchitechtContext architechtContext, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _architechtContext = architechtContext;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;

        }

        public ICategoryRepository CategoryRepository => _categoryRepository;

        public IProductRepository ProductRepository => _productRepository;


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
