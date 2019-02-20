using Malveen.Dominio.Repository.Interface.Login.v1;
using Malveen.Dominio.Repository.Interface.Usuarios.v1;
using Malween.Cliente.Servico.Interface.Usuario;
using Malween.Dominio.Globalizacao;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Cliente.Servico.Usuario.v1.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IStringLocalizer<Textos> _globalizacao;
        private readonly IUsuarioLoginRepositorio _usuarioLoginRepositorio;

        public UsuarioServico(
            IUsuarioRepositorio usuarioRepositorio,
            IStringLocalizer globalizacao,
            IUsuarioLoginRepositorio usuarioLoginRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _globalizacao = _globalizacao;
            _usuarioLoginRepositorio = usuarioLoginRepositorio;
        }


    }
}
