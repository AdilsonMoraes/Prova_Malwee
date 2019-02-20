using Malween.Cliente.Servico.Interface.Cliente;
using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Dominio.Servico.Interface.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.Controllers.Cliente.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _clienteServico;
        private readonly IErrosMapper _errosMapper;
        private readonly IDadosUsuarioServico _dadosUsuarioServico;

        public ClienteController(
            IClienteServico clienteServico,
            IErrosMapper errosMapper,
            IDadosUsuarioServico dadosUsuarioServico)
        {
            _clienteServico = clienteServico;
            _errosMapper = errosMapper;
            _dadosUsuarioServico = dadosUsuarioServico;
        }

        [Route("CadastrarCliente")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult CadastrarCliente(string Nome)
        {
            return Ok();
        }

        [Route("ConsultarCliente")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult ConsultarCliente(string Nome)
        {
            return Ok();
        }


    }
}