using Malveen.Dominio.Repository.Interface.Login.v1;
using Malween.Cliente.Servico.Login.v1.Validacao;
using Malween.Dominio.Globalizacao;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Servico.Interface.Login.v1;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Cliente.Servico.Login.v1
{
    public class UsuarioLoginServico: IUsuarioLoginServico
    {
        private readonly IUsuarioLoginRepositorio _repositorio;
        private readonly IStringLocalizer<Textos> _globalizacao;

        public UsuarioLoginServico(IUsuarioLoginRepositorio repositorio,
                                    IStringLocalizer<Textos> globalizacao)
        {
            _repositorio = repositorio;
            _globalizacao = globalizacao;
        }

        public UsuarioLogin Retorna(UsuarioLogin login)
        {
            if (IsValido(login))
            {
                return _repositorio.Retorna(login);
            }

            return default(UsuarioLogin);
        }

        public bool Cadastra(UsuarioLogin login)
        {
            if (!LoginExistePara(login.Usuario))
            {
                return _repositorio.Cadastra(login);
            }

            return false;
        }

        public bool AlteraSenhaDo(UsuarioLogin login)
        {
            return _repositorio.AlteraSenhaDo(login);
        }

        private bool LoginExistePara(string nomeUsuario)
        {
            return _repositorio.LoginExistePara(nomeUsuario);
        }

        private bool IsValido(UsuarioLogin login)
        {
            var validacao = new ValidaUsuarioLogin(_globalizacao);
            return validacao.Validate(login).IsValid;
        }
    }
}
