using Architecht.Application.DTO;
using Architecht.Domain.Models;
using Architecht.Infrastructure.UnitOfWork;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.Service
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public string GenerateToken(string userId, string email)
        {

            var tokenHandler = new JwtSecurityTokenHandler();

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("istanbulizmirankaraistanbulizmirankaraistanbul"));

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDesctiptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId),
                    new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Email, email)
                }),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = credentials,
                Issuer = "Architecht",
                Audience = "Architecht"
            };

            var token = tokenHandler.CreateToken(tokenDesctiptor);
            var tokenData = tokenHandler.WriteToken(token);

            return tokenData;
            
        }


        public RefreshToken GenerateRefreshToken(Guid userId)
        {
            var refreshToken = new RefreshToken()
            {
                UserId = userId,
                Token = Guid.NewGuid().ToString(),
                Expires = DateTime.Now.AddDays(7)
            };

            _unitOfWork.RefreshTokenRepository.Create(refreshToken);
            _unitOfWork.SaveChanges();

            return refreshToken;
        }


        //bu metoda gonderilen token refresh tokendir ve db de varsa ve sure vb. kosullari sagliyorsa access token doner
        public RefreshTokenResponseDto RefreshToken(string token)
        {
            var refreshToken = _unitOfWork.RefreshTokenRepository.FirstOrDefault(q => q.Token == token);

            if (refreshToken == null)
            {
                throw new Exception("refreshToken not found");
            }
            if (refreshToken.IsRevoked)
            {
                throw new Exception("refreshToken revoked");
            }
            if(refreshToken.Expires < DateTime.Now)
            {
                throw new Exception("refreshToken expired");
            }

            var user = _unitOfWork.UserRepository.FirstOrDefault(q => q.Id == refreshToken.UserId);

            if(user == null)
            {
                throw new Exception("User not found!");
            }
          

            refreshToken.IsUsed = true;
            refreshToken.Used = DateTime.Now;
            _unitOfWork.SaveChanges();

            //db ye yeni bir refreshtoken ekliyorum
            var newRefreshToken = GenerateRefreshToken(user.Id);
            


            var response = new RefreshTokenResponseDto();
            var newAccessToken = GenerateToken(user.Id.ToString(), user.EMail);


            response.AccessToken = newAccessToken;
            response.RefreshToken = newRefreshToken.Token;


            return response;
        }
    }
}
