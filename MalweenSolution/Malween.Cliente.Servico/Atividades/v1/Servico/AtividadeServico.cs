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

        //public MensagemResposta Adicionar(Atividade dados)
        //{
        //    var resposta = new MensagemResposta();

        //    var validacao = new AdicionarValidacao(_globalizacao);

        //    var resultado = validacao.Validate(dados);
        //    resposta.Erros = resultado.ToErro();

        //    if (resultado.IsValid)
        //    {
        //        resposta.CorrelationId = _integracaoServico.EnviarAsync<Atividade, ICadastrarAtividadeFila>(dados, Dominio.Integracoes.Enum.Filas.ToCOLD);
        //        _respostaServico.InserirAguardando(resposta.CorrelationId);
        //    }

        //    return resposta;
        //}


    }
}
