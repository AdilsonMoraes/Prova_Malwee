using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Dominio.Servico.Interface.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.Controllers.Relatorios.v1.Estatisticas.Cliente
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class EstatisticasClientesController : ControllerBase
    {
        private readonly IErrosMapper _errosMapper;
        private readonly IDadosUsuarioServico _dadosUsuarioServico;

        public EstatisticasClientesController(IErrosMapper errosMapper,
            IDadosUsuarioServico dadosUsuarioServico)
        {
            _errosMapper = errosMapper;
            _dadosUsuarioServico = dadosUsuarioServico;
        }

        [Route("ConsultarTopTresClientesPorValor")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult ConsultarTopTresClientesPorValor()
        {
            return Ok();
        }

    }
}