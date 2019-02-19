using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio;
using Malveen.Dominio.Repository.Interface.Fornecedores.v1;
using Malween.Dominio.Fornecedor.v1;

namespace Malveen.Dominio.Infraestrutura.Fornecedores.v1.Repositorio
{
    public class FornecedorRepositorio : CrudRepositorio<Fornecedor>, IFornecedorRepositorio
    {
        private readonly ContextoDominio _contexto;

        public FornecedorRepositorio(ContextoDominio contexto) : base(contexto)
        {
            _contexto = contexto;
        }

    }
}
