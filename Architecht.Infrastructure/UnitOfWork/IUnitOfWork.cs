using Architecht.Infrastructure.Repositories.ECommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        void SaveChanges();
    }
}
