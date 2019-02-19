using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio;
using Malveen.Dominio.Repository.Interface.Usuarios.v1;
using Malween.Dominio.Usuario.v1;
using System.Linq;

namespace Malveen.Dominio.Infraestrutura.Usuarios.v1.Repositorio
{
    public class UsuarioRepositorio : CrudRepositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly ContextoDominio _contexto;

        public UsuarioRepositorio(ContextoDominio contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Usuario BuscarUsuarioPadraoWS()
        {
            return _contexto
                .Usuario
                .Where(u => u.Email.Equals("Sys. WebAPI"))
                .FirstOrDefault();
        }

        public Usuario RetornaUsuarioPeloId(int id)
        {
            var usuario = base.ObterPorId(id);

            if (usuario != null)
            {
                return usuario;
            }

            return null;
        }
    }
}
