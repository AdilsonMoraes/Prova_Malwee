using Malween.Dominio.Login.v1;
using Malween.Dominio.ValueObjects.Jwt;
using System;

namespace Malween.Cliente.Autenticacao.Interface
{
    public interface IJwtService
    {
        JwtTokenSettings Settings { get; }
        string CriaJsonWebToken(UsuarioLogin user);
    }
}
