using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Mensagens.v1;
using Malween.Dominio.Servico.Interface.Login.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.v1.Controllers.Usuario
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioLoginServico usuarioLoginServico;

        public UsuarioController(IUsuarioLoginServico usuarioLoginServico)
        {
            this.usuarioLoginServico = usuarioLoginServico;
        }

        [HttpPost("CadastrarUsuario")]
        public IActionResult CadastrarUsuario([FromBody]UsuarioLogin login)
        {
            try
            {
                bool cadastrou = usuarioLoginServico.Cadastra(login);
                if (cadastrou)
                {
                    return Ok();
                }

                return BadRequest(new List<ErroException>() { new ErroException("2", "Login já cadastrado.") });
            }
            catch (Exception e)
            {
                return BadRequest(new List<ErroException>() { new ErroException("2", e.Message) });
            }
        }

        [HttpPut("AlterarSenha")]
        public IActionResult AlterarSenha([FromBody]UsuarioLogin login)
        {
            try
            {
                bool alterou = usuarioLoginServico.AlteraSenhaDo(login);
                if (alterou)
                {
                    return Ok();
                }

                return BadRequest(new List<ErroException>() { new ErroException("2", "Houve um problema na hora de alterar a senha.") });
            }
            catch (Exception e)
            {
                return BadRequest(new List<ErroException>() { new ErroException("2", e.Message) });
            }
        }
    }
}