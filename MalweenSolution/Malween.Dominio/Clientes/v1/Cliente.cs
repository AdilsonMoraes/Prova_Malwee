using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Malween.Dominio.Clientes.v1
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
