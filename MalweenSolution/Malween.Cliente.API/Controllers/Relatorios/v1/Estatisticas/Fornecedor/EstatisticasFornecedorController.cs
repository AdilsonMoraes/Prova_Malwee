using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Dominio.Servico.Interface.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.Controllers.Relatorios.v1.Estatisticas.Fornecedor
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class EstatisticasFornecedorController : ControllerBase
    {
        private readonly IErrosMapper _errosMapper;
        private readonly IDadosUsuarioServico _dadosUsuarioServico;

        public EstatisticasFornecedorController(IErrosMapper errosMapper,
            IDadosUsuarioServico dadosUsuarioServico)
        {
            _errosMapper = errosMapper;
            _dadosUsuarioServico = dadosUsuarioServico;
        }

        [Route("ConsultarMediaValorCobradoServico")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult ConsultarMediaValorCobradoServico()
        {
            return Ok();
        }

        [Route("ConsultarFornecedorSemPrestarServicoMes")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult ConsultarFornecedorSemPrestarServicoMes()
        {
            return Ok();
        }

    }
}