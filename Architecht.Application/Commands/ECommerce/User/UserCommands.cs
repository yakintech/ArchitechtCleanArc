using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Commands
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
