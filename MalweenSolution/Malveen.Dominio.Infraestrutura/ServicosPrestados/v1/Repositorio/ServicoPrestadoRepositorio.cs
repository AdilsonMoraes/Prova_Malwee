using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio;
using Malveen.Dominio.Repository.Interface.ServicosPrestados.v1;
using Malween.Dominio.ServicosPrestados.v1;

namespace Malveen.Dominio.Infraestrutura.ServicosPrestados.v1.Repositorio
{
    public class ServicoPrestadoRepositorio : CrudRepositorio<ServicoPrestado>, IServicoPrestadoRepositorio
    {
        private readonly ContextoDominio _contexto;

        public ServicoPrestadoRepositorio(ContextoDominio contexto) : base(contexto)
        {
            _contexto = contexto;
        }

    }
}
