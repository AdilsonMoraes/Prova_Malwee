using Malween.Dominio.Usuario.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Repository.Interface.Usuarios.v1
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarUsuarioPadraoWS();
        Usuario RetornaUsuarioPeloId(int id);
    }
}
