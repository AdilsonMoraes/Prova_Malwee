using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Mensagens.v1;
using Malween.Dominio.Mensagens.v1.Enum;
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
            var resposta = new MensagemResposta();

            try
            {
                usuarioLoginServico.Cadastra(login);
                resposta.Dados = "null";
                resposta.Status = MensagemRespostaStatus.S;
                resposta.Dados = "Sucesso";
                return Ok(resposta);

            }
            catch (ErroException e)
            {
                resposta.Dados = $"Usuário: {login.Usuario} ";
                resposta.Status = MensagemRespostaStatus.Erro;
                resposta.Erros = new List<Erro> { new Erro() { Codigo = e.Codigo, Descricao = e.Descricao } };
                return BadRequest(resposta);
            }

            catch (Exception e)
            {
                resposta.Dados = "null";
                resposta.Status = MensagemRespostaStatus.Erro;
                resposta.Erros = new List<Erro> { new Erro() { Codigo = "99", Descricao = $"{e.Message}" } };
                return BadRequest(resposta);
            }
        }

        [HttpPut("AlterarSenha")]
        public IActionResult AlterarSenha([FromBody]UsuarioLogin login)
        {
            var resposta = new MensagemResposta();

            try
            {
                usuarioLoginServico.AlteraSenhaDo(login);
                resposta.Dados = "null";
                resposta.Status = MensagemRespostaStatus.S;
                resposta.Dados = "Sucesso";
                return Ok(resposta);
            }
            catch (ErroException e)
            {
                resposta.Dados = $"Usuário: {login.Usuario} / Senha: {login.Senha}";
                resposta.Status = MensagemRespostaStatus.Erro;
                resposta.Erros = new List<Erro> { new Erro() { Codigo = e.Codigo, Descricao = e.Descricao } };
                return BadRequest(resposta);
            }
            catch (Exception e)
            {
                resposta.Dados = "null";
                resposta.Status = MensagemRespostaStatus.Erro;
                resposta.Erros = new List<Erro> { new Erro() { Codigo = "99", Descricao = $"{e.Message}" } };
                return BadRequest(resposta);
            }
        }
    }
}