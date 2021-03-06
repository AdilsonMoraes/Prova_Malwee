﻿using Malween.Dominio.Login.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Repository.Interface.Login.v1
{
    public interface IUsuarioLoginRepositorio
    {
        UsuarioLogin Retorna(UsuarioLogin login);
        bool LoginExistePara(string nomeUsuario);
        bool Cadastra(UsuarioLogin login);
        bool AlteraSenhaDo(UsuarioLogin login);
    }
}
