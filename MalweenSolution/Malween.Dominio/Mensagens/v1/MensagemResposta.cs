using Malween.Dominio.Mensagens.v1.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Mensagens.v1
{
    public class MensagemResposta
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MensagemRespostaStatus? Status { get; set; }

        [JsonProperty("dados")]
        public string Dados { get; set; }

        [JsonProperty("erros")]
        public IEnumerable<Erro> Erros { get; set; }
    }
}
