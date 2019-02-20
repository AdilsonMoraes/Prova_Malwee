using Malween.Dominio.Usuarios.v1;

namespace Malveen.Dominio.Repository.Interface.Usuarios.v1
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarUsuarioPadraoWS();
        Usuario RetornaUsuarioPeloId(int id);
    }
}
