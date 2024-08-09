using Architecht.Infrastructure.Repositories;
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

        IOrderRepository OrderRepository { get; }
        IUserRepository UserRepository { get; }
        void SaveChanges();
    }
}
