using Malveen.Dominio.Repository.Interface.Fornecedores.v1;
using Malveen.Dominio.Repository.Interface.Login.v1;
using Malween.Cliente.Servico.Interface.Fornecedor;
using Malween.Dominio.Globalizacao;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Cliente.Servico.Fornecedor.v1.Servico

{
    public class FornecedorServico : IFornecedorServico
    {

        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        private readonly IStringLocalizer<Textos> _globalizacao;
        private readonly IUsuarioLoginRepositorio _usuarioLoginRepositorio;

        public FornecedorServico(
            IFornecedorRepositorio fornecedorRepositorio,
            IStringLocalizer globalizacao,
            IUsuarioLoginRepositorio usuarioLoginRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _globalizacao = _globalizacao;
            _usuarioLoginRepositorio = usuarioLoginRepositorio;
        }



    }
}
