using Malveen.Dominio.Infraestrutura.Contextos;
using Malveen.Dominio.Repository.Interface.Login.v1;
using Malween.Dominio.Login.v1;
using System.Linq;

namespace Malveen.Dominio.Infraestrutura.Login.Repositorio
{
    public class UsuarioLoginRepositorio : IUsuarioLoginRepositorio
    {
        private ContextoDominio _contexto;

        public UsuarioLoginRepositorio(ContextoDominio contexto)
        {
            _contexto = contexto;
        }

        public UsuarioLogin Retorna(UsuarioLogin login)
        {
            return _contexto.Logins
                .Where(l => l.Senha.Equals(login.Senha)
                       && l.Usuario.Equals(login.Usuario)
                       ).FirstOrDefault();
        }

        public bool LoginExistePara(string nomeUsuario)
        {
            return _contexto.Logins
                .Where(l => l.Usuario.Equals(nomeUsuario)
                       )
                .Count() > 0;
        }

        public bool Cadastra(UsuarioLogin login)
        {
            _contexto.Add(login);
            return _contexto.SaveChanges() > 0;
        }

        public bool AlteraSenhaDo(UsuarioLogin login)
        {
            _contexto.Update(login);
            return _contexto.SaveChanges() > 0;
        }
    }
}
