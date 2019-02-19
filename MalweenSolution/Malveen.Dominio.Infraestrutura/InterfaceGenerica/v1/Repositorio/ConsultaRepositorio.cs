using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Repository.Interface.InterfaceGenerica.v1;

namespace Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio
{
    public class ConsultaRepositorio<TEntity> : IConsultaRepositorio<TEntity> where TEntity : class
    {
        private readonly ContextoDominio _contexto;

        public ConsultaRepositorio(ContextoDominio contexto)
        {
            _contexto = contexto;
        }

        public TEntity ObterPorId(object id)
        {
            return _contexto.Set<TEntity>()
                .Find(id);
        }
    }
}
