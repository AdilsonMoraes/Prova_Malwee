using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using Malween.Dominio.Usuarios.v1;

namespace Malween.Dominio.Fornecedores.v1
{
    public class Fornecedor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [JsonProperty("id_fornecedor")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
