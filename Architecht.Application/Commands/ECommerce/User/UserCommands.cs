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

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }
    }


    public class LoginUserCommand : IRequest<LoginUserCommandResponse>
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }   


    public class LoginUserCommandResponse
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
