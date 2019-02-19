using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Cliente.v1
{
    public class Cliente
    {
        [JsonProperty("id_cliente")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("cidade")]
        public string Cidade { get; set; }
        [JsonProperty("estado")]
        public string Estado { get; set; }
    }
}
