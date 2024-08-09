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
        private readonly IOrderRepository _orderRepository;


        public UnitOfWork(ArchitechtContext architechtContext, ICategoryRepository categoryRepository, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _architechtContext = architechtContext;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;

        }

        public ICategoryRepository CategoryRepository => _categoryRepository;

        public IProductRepository ProductRepository => _productRepository;

        public IOrderRepository OrderRepository => _orderRepository;


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
