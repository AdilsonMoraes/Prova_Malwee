using Malveen.Dominio.Repository.Interface.Login.v1;
using Malween.Cliente.Servico.Login.v1.Validacao;
using Malween.Dominio.Globalizacao;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Mensagens.v1;
using Malween.Dominio.Mensagens.v1.Enum;
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

        public void Cadastra(UsuarioLogin login)
        {
            bool result = false;
            bool validaUser = LoginExistePara(login.Usuario);

            if (!validaUser)
            {
                result = _repositorio.Cadastra(login);
            }

            if (validaUser || !result)
            {
                throw new ErroException(GeralEnumException.LoginJaCadastrado.Codigo.ToString(), 
                    GeralEnumException.LoginJaCadastrado.Valor);
            }

        }

        public void AlteraSenhaDo(UsuarioLogin login)
        {
            bool result = false;
            bool validaUser = LoginExistePara(login.Usuario);

            if (validaUser)
            {
                result = _repositorio.AlteraSenhaDo(login);
            }

            if (!validaUser || !result)
            {
                throw new ErroException(GeralEnumException.ProblemaParaAlterarSenha.Codigo.ToString(), 
                    GeralEnumException.ProblemaParaAlterarSenha.Valor);
            }
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
