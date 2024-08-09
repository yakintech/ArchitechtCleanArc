using Architecht.Application.DTO;
using Architecht.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Service
{
    public interface IAuthenticationService
    {
        string GenerateToken(string userId, string email);
        RefreshTokenResponseDto RefreshToken(string token);

        RefreshToken GenerateRefreshToken(Guid userId);
        
    }
}
