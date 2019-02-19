using Malween.Dominio.Login.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Servico.Interface.Login.v1
{
    public interface IUsuarioLoginServico
    {
        UsuarioLogin Retorna(UsuarioLogin login);
        bool Cadastra(UsuarioLogin login);
        bool AlteraSenhaDo(UsuarioLogin login);
    }
}
