using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Cliente.Servico.Interface.Usuario;
using Malween.Dominio.Servico.Interface.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.Controllers.Usuario.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        private readonly IErrosMapper _errosMapper;
        private readonly IDadosUsuarioServico _dadosUsuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico,
            IErrosMapper errosMapper,
            IDadosUsuarioServico dadosUsuarioServico)
        {
            _usuarioServico = usuarioServico;
            _errosMapper = errosMapper;
            _dadosUsuarioServico = dadosUsuarioServico;
        }

        [Route("CadastrarUsuario")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult CadastrarUsuario()
        {
            return Ok();
        }

        [Route("ConsultarUsuario")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult ConsultarUsuario(int id)
        {
            return Ok();
        }


    }
}