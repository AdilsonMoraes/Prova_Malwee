using Malveen.Dominio.Repository.Interface.Login.v1;
using Malveen.Dominio.Repository.Interface.ServicosPrestados.v1;
using Malween.Cliente.Servico.Interface.ServicoPrestado;
using Malween.Dominio.Globalizacao;
using Microsoft.Extensions.Localization;

namespace Malween.Cliente.Servico.ServicosPrestados.v1.Servico
{
    public class ServicoPrestadoServico : IServicoPrestadoServico
    {
        private readonly IServicoPrestadoRepositorio _servicoPrestadoRepositorio;
        private readonly IStringLocalizer<Textos> _globalizacao;
        private readonly IUsuarioLoginRepositorio _usuarioLoginRepositorio;

        public ServicoPrestadoServico(
            IServicoPrestadoRepositorio servicoPrestadoRepositorio,
            IStringLocalizer globalizacao,
            IUsuarioLoginRepositorio usuarioLoginRepositorio)
        {
            _servicoPrestadoRepositorio = servicoPrestadoRepositorio;
            _globalizacao = _globalizacao;
            _usuarioLoginRepositorio = usuarioLoginRepositorio;
        }




    }
}
