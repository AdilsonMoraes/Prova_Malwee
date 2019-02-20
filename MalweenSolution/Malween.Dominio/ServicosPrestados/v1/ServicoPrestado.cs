using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Malween.Dominio.ServicosPrestados.v1
{
    public class ServicoPrestado 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id_ServicoPrestado")]
        public int Id { get; set; }
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
        [JsonProperty("Data_Atendimento")]
        public DateTime DataAtendimento { get; set; }
        [JsonProperty("Valor_Servico")]
        public double ValorServico { get; set; }
        [JsonProperty("Tipo")]
        public string Tipo { get; set; }
    }
}
