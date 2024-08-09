using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Domain.Models
{
    public class User : BaseEntity
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
