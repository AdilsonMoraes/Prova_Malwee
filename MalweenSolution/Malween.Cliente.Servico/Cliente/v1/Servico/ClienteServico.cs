using Malveen.Dominio.Repository.Interface.Clientes.v1;
using Malveen.Dominio.Repository.Interface.Login.v1;
using Malween.Cliente.Servico.Interface.Cliente;
using Malween.Dominio.Globalizacao;
using Microsoft.Extensions.Localization;

namespace Malween.Cliente.Servico.Cliente.v1.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IStringLocalizer<Textos> _globalizacao;
        private readonly IUsuarioLoginRepositorio _usuarioLoginRepositorio;

        public ClienteServico(
            IClienteRepositorio clienteRepositorio,
            IStringLocalizer globalizacao,
            IUsuarioLoginRepositorio usuarioLoginRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            _globalizacao = _globalizacao;
            _usuarioLoginRepositorio = usuarioLoginRepositorio;
        }



    }
}
