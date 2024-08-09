using Architecht.Application.Service;
using Architecht.Infrastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Commands.ECommerce.User
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserCommandResponse>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticationService _authenticationService;

        public LoginUserCommandHandler(IUnitOfWork unitOfWork, IAuthenticationService authenticationService)
        {
            _unitOfWork = unitOfWork;
            _authenticationService = authenticationService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {

            var user = _unitOfWork.UserRepository.FirstOrDefault(q => q.EMail == request.EMail.ToLower().Trim() && q.Password == request.Password);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            var token = _authenticationService.GenerateToken(user.Id.ToString(), user.EMail);
            var refreshTokenModel = _authenticationService.GenerateRefreshToken(user.Id);

            var loginCommandResponse = new LoginUserCommandResponse
            {
                UserId = user.Id,
                Token = token,
                RefreshToken = refreshTokenModel.Token
            };

            return loginCommandResponse;
        }
    }
}
