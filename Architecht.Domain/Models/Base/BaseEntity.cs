using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Domain.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        //public BaseEntity()
        //{
        //    Id = Guid.NewGuid();
        //    CreatedAt = DateTime.Now;
        //    UpdatedAt = DateTime.Now;
        //    IsDeleted = false;
        //}
    }
}
