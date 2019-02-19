using Newtonsoft.Json;

namespace Malween.Dominio.Fornecedor.v1
{
    public class Fornecedor
    {
        [JsonProperty("id_fornecedor")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
