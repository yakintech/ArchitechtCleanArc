using Architecht.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Domain.Models
{
    public class Product : BaseEntity, ISort
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int SortOrder { get; set; }

        public Guid? CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}
