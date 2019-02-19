using Malween.Dominio.Globalizacao;
using Malween.Dominio.Servico.Interface.Atividades.v1;
using Microsoft.Extensions.Localization;

namespace Malween.Cliente.Servico.Atividades.v1.Servico
{
    public class AtividadeServico : IAtividadeServico
    {

        private readonly IStringLocalizer<Textos> _globalizacao;

        public AtividadeServico(
            IStringLocalizer<Textos> globalizacao)
        {
            _globalizacao = globalizacao;
        }
    }
}
