using Malveen.Dominio.Repository.Interface.ServicosPrestados.v1;
using Malween.Cliente.Servico.Interface.ServicoPrestado;

namespace Malween.Cliente.Servico.ServicosPrestados
{
    public class ServicoPrestadoServico : IServicoPrestadoServico
    {
        private readonly IServicoPrestadoRepositorio _servicoPrestadoRepositorio;

        public ServicoPrestadoServico(
            IServicoPrestadoRepositorio servicoPrestadoRepositorio)
        {
            _servicoPrestadoRepositorio = servicoPrestadoRepositorio;
        }




    }
}
