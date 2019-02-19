using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Repository.Interface.InterfaceGenerica.v1;

namespace Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio
{
    public class CrudRepositorio<TEntity> : ConsultaRepositorio<TEntity>,
          ICrudRepositorio<TEntity> where TEntity : class
    {
        protected readonly ContextoDominio contexto;

        public CrudRepositorio(ContextoDominio contexto) : base(contexto)
        {
            this.contexto = contexto;
        }

        public virtual void Altera(TEntity item)
        {
            contexto.Set<TEntity>().Update(item);
            contexto.SaveChanges();
        }

        public virtual void Cadastra(TEntity item)
        {
            contexto.Set<TEntity>().Add(item);
            contexto.SaveChanges();
        }

        public virtual void Deleta(TEntity item)
        {
            contexto.Set<TEntity>().Remove(item);
            contexto.SaveChanges();
        }
    }
}