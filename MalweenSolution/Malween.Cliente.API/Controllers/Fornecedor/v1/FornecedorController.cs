using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Cliente.Servico.Interface.Fornecedor;
using Malween.Dominio.Servico.Interface.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Malween.Cliente.API.Controllers.Fornecedor.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorServico _fornecedorServico;
        private readonly IErrosMapper _errosMapper;
        private readonly IDadosUsuarioServico _dadosUsuarioServico;

        public FornecedorController(
            IFornecedorServico fornecedorServico,
            IErrosMapper errosMapper,
            IDadosUsuarioServico dadosUsuarioServico)
        {
            _fornecedorServico = fornecedorServico;
            _errosMapper = errosMapper;
            _dadosUsuarioServico = dadosUsuarioServico;
        }


        [Route("CadastrarFornecedor")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult CadastrarFornecedor(string Nome)
        {
            return Ok();
        }

        [Route("ConsultarFornecedor")]
        [HttpPost]
        //Faltou criar o DTO
        public IActionResult ConsultarFornecedor(string Nome)
        {
            return Ok();
        }

    }
}