using Malween.Cliente.Autenticacao.Interface;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Mensagens.v1;
using Malween.Dominio.Servico.Interface.Login.v1;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Malween.Cliente.API.Controllers.Autenticar.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AutenticarController : ControllerBase
    {
        private readonly IJwtService jwtService;
        private readonly IUsuarioLoginServico usuarioLoginServico;

        public AutenticarController(IJwtService jwtService,
            IUsuarioLoginServico usuarioLoginServico)
        {
            this.jwtService = jwtService;
            this.usuarioLoginServico = usuarioLoginServico;
        } 
        
        [HttpPost("GerarToken")]
        public IActionResult GerarToken([FromBody]UsuarioLogin login)
        {
            UsuarioLogin usuario = usuarioLoginServico.Retorna(login);

            if (usuario != default(UsuarioLogin))
            {
                var token = jwtService.CriaJsonWebToken(usuario);
                return Ok(token);
            }

            return BadRequest(new List<ErroException>() { new ErroException("2", "Usuário inválido") });
        }
    }
}