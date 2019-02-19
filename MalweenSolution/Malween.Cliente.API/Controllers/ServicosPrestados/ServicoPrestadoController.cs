using Malwee.Dominio.DTO.ServicoPrestadoDTO.v1;
using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Cliente.Servico.Interface.ServicoPrestado;
using Malween.Dominio.Servico.Interface.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.Controllers.ServicosPrestados
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class ServicoPrestadoController : ControllerBase
    {
        private readonly IServicoPrestadoServico _servicoPrestadoServico;
        private readonly IErrosMapper _errosMapper;
        private readonly IDadosUsuarioServico _dadosUsuarioServico;

        public ServicoPrestadoController(
            IServicoPrestadoServico servicoPrestadoServico,
            IErrosMapper errosMapper,
            IDadosUsuarioServico dadosUsuarioServico)
        {
            _servicoPrestadoServico = servicoPrestadoServico;
            _errosMapper = errosMapper;
            _dadosUsuarioServico = dadosUsuarioServico;
        }

        [Route("GravarServicoPrestado")]
        [HttpPost]
        public IActionResult GravarServicoPrestado([FromBody]ServicoPrestadoDTO dados)
        {
            return Ok();
        }

        [Route("ConsultarServicoPrestado")]
        [HttpPost]
        public IActionResult ConsultarServicoPrestado([FromBody]ServicoPrestadoConsultaDTO dados)
        {
            return Ok();
        }

    }
}