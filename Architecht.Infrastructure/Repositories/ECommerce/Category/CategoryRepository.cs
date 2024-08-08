using Architecht.Domain.Models;
using Architecht.Infrastructure.EF;
using Architecht.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.Repositories.ECommerce
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ArchitechtContext context) : base(context)
        {
        }
    }
}
