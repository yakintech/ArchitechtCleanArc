using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Domain.Models.Base
{
    public interface ISort
    {
        int SortOrder { get; set; }
    }
}
