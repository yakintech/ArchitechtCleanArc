using Architecht.Application.Commands;
using Architecht.Application.DTO;
using Architecht.Application.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Architecht.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediatR;
        private readonly IAuthenticationService _authenticationService;

        public AccountController(IMediator mediatR, IAuthenticationService authenticationService)
        {
            _mediatR = mediatR;
            _authenticationService = authenticationService;
            
        }


        [HttpPost]
        public async Task<IActionResult> Post(RegisterUserDto model)
        {
            var createUserCommand = new CreateUserCommand
            {
                EMail = model.EMail,
                Password = model.Password
            };

            var result = await _mediatR.Send(createUserCommand);

            return Ok(result);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto model)
        {
            var loginUserCommand = new LoginUserCommand
            {
                EMail = model.EMail,
                Password = model.Password
            };

            var result = await _mediatR.Send(loginUserCommand);

            return Ok(result);
        }


        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(RefreshTokenRequestDto model)
        {
            var token = _authenticationService.RefreshToken(model.Token);
           
            return Ok(token);
        }

    }
}
