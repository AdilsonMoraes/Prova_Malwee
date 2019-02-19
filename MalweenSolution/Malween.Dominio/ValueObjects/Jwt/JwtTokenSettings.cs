using Microsoft.IdentityModel.Tokens;

namespace Malween.Dominio.ValueObjects.Jwt
{
    public class JwtTokenSettings
    {
        public string Audience { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string IssuerSigningKey { get; set; } = string.Empty;
        public int ExpirationInMinutes { get; set; }
        public SigningCredentials SigningCredentials { get; }
    }
}
